using UnityEngine;

public class OVRGrabbableShadow : OVRGrabbable
{
    public GameObject shadow;

    private MeshRenderer shadowRenderer = null;
    private MeshRenderer[] shadowRenderers = null;

    protected override void Start()
    {
        if (this.shadow.transform.childCount > 0)
        {
            this.shadowRenderers = this.shadow.GetComponentsInChildren<MeshRenderer>();
        }
        else
        {
            this.shadowRenderer = this.shadow.GetComponent<MeshRenderer>();
        }


        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = false;
        }
        else if (this.shadowRenderers != null)
        {
            foreach (var sr in this.shadowRenderers)
            {
                sr.enabled = false;
            }
        }

        base.Start();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = true;
        }
        else if (this.shadowRenderers != null)
        {
            foreach (var sr in this.shadowRenderers)
            {
                sr.enabled = true;
            }
        }

        base.GrabBegin(hand, grabPoint);
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        if (this.shadowRenderer)
        {
            this.shadowRenderer.enabled = false;
        }
        else if (this.shadowRenderers != null)
        {
            foreach (var sr in this.shadowRenderers)
            {
                sr.enabled = false;
            }
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
