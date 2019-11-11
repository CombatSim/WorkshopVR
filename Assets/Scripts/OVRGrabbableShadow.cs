using UnityEngine;

public class OVRGrabbableShadow : OVRGrabbable
{
    public GameObject shadow;

    private MeshRenderer shadowRenderer;

    protected override void Start()
    {
        this.shadowRenderer = this.shadow.GetComponent<MeshRenderer>();

        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = false;
        }

        base.Start();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = true;
        }

        base.GrabBegin(hand, grabPoint);
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = false;
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
