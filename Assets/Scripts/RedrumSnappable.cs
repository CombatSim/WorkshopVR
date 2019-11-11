using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnappable : MonoBehaviour
{
    private RedrumSnap redrumSnap;
    private bool snapped;
    private OVRGrabbable ovrGrabbable;

    // Start is called before the first frame update
    void Start()
    {
        this.redrumSnap = transform.parent.GetComponent<RedrumSnap>();
        this.ovrGrabbable = GetComponent<OVRGrabbable>();

        this.snapped = false;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(new Vector3(0, 0, 0), transform.localPosition);

        if (dist < 10f && this.redrumSnap.CanSnapChild(this.name))
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.transform.localEulerAngles = new Vector3(0, -180, 0);
            this.ovrGrabbable.grabbedBy.ForceRelease(this.ovrGrabbable);
            
            this.redrumSnap.SnapChild(this.name);
            this.snapped = true;
        }
    }
}