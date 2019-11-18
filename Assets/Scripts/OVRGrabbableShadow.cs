using UnityEngine;

public class OVRGrabbableShadow : OVRGrabbable
{
    public GameObject shadowOk;
    public GameObject shadowNope;
    public GameObject upInd;

    private Snapper snapper;

    protected override void Start()
    {
        if (this.shadowOk)
        {
            this.shadowOk.SetActive(false);
        }

        if (this.shadowNope)
        {
            this.shadowNope.SetActive(false);
        }

        if (this.upInd)
        {
            this.upInd.SetActive(false);
        }

        this.snapper = transform.parent.GetComponent<Snapper>();

        base.Start();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        bool canSnap = false;

        if (this.snapper)
        {
            canSnap = this.snapper.CanSnapChild(this.name);
        }

        if (this.shadowOk && canSnap)
        {
            this.shadowOk.SetActive(true);
        }
        else if (this.shadowNope && !canSnap)
        {
            this.shadowNope.SetActive(true);
        }

        if (this.upInd)
        {
            this.upInd.SetActive(true);
        }

        base.GrabBegin(hand, grabPoint);
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        if (this.shadowOk)
        {
            this.shadowOk.SetActive(false);
        }

        if (this.shadowNope)
        {
            this.shadowNope.SetActive(false);
        }

        if (this.upInd)
        {
            this.upInd.SetActive(false);
        }

        base.GrabEnd(linearVelocity, angularVelocity);
    }

    public void Ungrab()
    {
        if (m_grabbedBy != null)
        {
            m_grabbedBy.ForceRelease(this);
        }
    }
}
