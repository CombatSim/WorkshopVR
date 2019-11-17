using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnappable : MonoBehaviour
{
    public GameObject screws;
    public float snapDistance = 10f;
    private RedrumSnap redrumSnap;
    private bool snapped;
    private OVRGrabbableShadow ovrGrabbable;

    // Start is called before the first frame update
    void Start()
    {
        this.redrumSnap = transform.parent.GetComponent<RedrumSnap>();
        this.ovrGrabbable = GetComponent<OVRGrabbableShadow>();

        if (screws)
        {
            screws.SetActive(false);
        }

        this.snapped = false;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(new Vector3(0, 0, 0), transform.localPosition);

        if (dist < this.snapDistance && this.redrumSnap.CanSnapChild(this.name))
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.transform.localEulerAngles = new Vector3(0, -180, 0);

            this.ovrGrabbable.Ungrab();

            this.redrumSnap.SnapChild(this.name);
            this.snapped = true;

            if (screws)
            {
                screws.SetActive(true);
            }
        }
    }
}
