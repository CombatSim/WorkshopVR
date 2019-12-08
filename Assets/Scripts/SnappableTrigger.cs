using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SnappableTrigger : MonoBehaviour
{
    public GameObject screws;
    public Collider targetCollider;

    public float angularSnapTolerance = 10f;
    public float colliderPercTolerance = 0.8f;
    public bool snapped;

    public float angularDist;
    public float percentage;

    private Snapper snapper;
    private OVRGrabbableShadow ovrGrabbable;
    private Rigidbody rb;
    private Collider[] colliders;

    private GameObject originalParent;
    private GameObject tempPoint;

    // Start is called before the first frame update
    void Start()
    {
        this.snapper = GetComponentInParent<Snapper>();
        this.ovrGrabbable = GetComponent<OVRGrabbableShadow>();
        this.rb = GetComponent<Rigidbody>();
        this.colliders = GetComponents<Collider>();
        this.originalParent = transform.parent.gameObject;

        if (screws)
        {
            screws.SetActive(false);
        }

        this.snapped = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " | " + this.snapper.name);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other != this.targetCollider)
        {
            return;
        }

        angularDist = Quaternion.Angle(Quaternion.Euler(Vector3.zero), transform.localRotation);

        if (angularDist < this.angularSnapTolerance && this.IsEnoughCollision(other) && this.snapper.CanSnapChild(this.name))
        {
            this.ovrGrabbable.Ungrab();
            this.ovrGrabbable.enabled = false;

            this.snapper.SnapChild(this.name);
            this.snapped = true;

            foreach (var collider in this.colliders)
            {
                collider.enabled = false;
            }

            if (this.rb)
            {
                this.rb.useGravity = false;
                this.rb.isKinematic = true;
            }

            this.tempPoint = new GameObject();
            this.tempPoint.transform.position = GetComponent<Renderer>().bounds.center;
            this.tempPoint.transform.SetParent(this.originalParent.transform);

            transform.SetParent(this.tempPoint.transform);

            this.tempPoint.transform.DOLocalRotate(Quaternion.Inverse(transform.localRotation).eulerAngles, 0.3f).OnComplete(() =>
            {
                transform.SetParent(this.originalParent.transform);
                Destroy(this.tempPoint);

                transform.DOLocalMove(Vector3.zero, 0.5f).OnComplete(() =>
                {
                    if (screws)
                    {
                        screws.SetActive(true);
                    }
                });
            });
        }
    }

    private bool IsEnoughCollision(Collider other)
    {
        var thisBounds = GetComponent<Collider>().bounds;
        var otherBounds = other.bounds;

        var total = 1f;

        for (var i = 0; i < 3; i++)
        {
            var dist = thisBounds.min[i] > otherBounds.center[i] ?
                thisBounds.max[i] - otherBounds.max[i] :
                otherBounds.min[i] - thisBounds.min[i];

            total *= Mathf.Clamp01(1f - dist / thisBounds.size[i]);
        }

        percentage = total;
        return total > this.colliderPercTolerance;
    }
}
