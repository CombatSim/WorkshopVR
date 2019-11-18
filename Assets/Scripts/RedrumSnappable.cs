using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnappable : MonoBehaviour
{
    public GameObject screws;
    public float snapDistance = 10f;
    private Snapper snapper;
    private bool snapped;
    private OVRGrabbableShadow ovrGrabbable;
    private Rigidbody rb;
    private BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        this.snapper = transform.parent.GetComponent<Snapper>();
        this.ovrGrabbable = GetComponent<OVRGrabbableShadow>();
        this.rb = GetComponent<Rigidbody>();
        this.bc = GetComponent<BoxCollider>();

        if (screws)
        {
            screws.SetActive(false);
        }

        this.snapped = false;

        print("Starting Snappable for " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.snapped)
        {
            return;
        }

        float dist = Vector3.Distance(new Vector3(0, 0, 0), transform.localPosition);
        float angularDist = Vector3.Distance(new Vector3(0, 0, 0), transform.transform.localEulerAngles);

        if (dist < this.snapDistance && angularDist < 10 && this.snapper.CanSnapChild(this.name))
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.transform.localEulerAngles = new Vector3(0, 0, 0);

            this.snapper.SnapChild(this.name);
            this.snapped = true;

            this.ovrGrabbable.Ungrab();
            this.ovrGrabbable.enabled = false;

            if (this.bc)
            {
                this.bc.enabled = false;
            }

            if (this.rb)
            {
                this.rb.useGravity = false;
                this.rb.isKinematic = true;
            }

            if (screws)
            {
                screws.SetActive(true);
            }
        }
    }
}
