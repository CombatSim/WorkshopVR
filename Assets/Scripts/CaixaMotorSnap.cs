using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaMotorSnap : Snapper
{
    private bool motor;
    private bool rolamento;
    private bool polia;

    // Start is called before the first frame update
    void Start()
    {
        motor = false;
        rolamento = false;
        polia = false;
    }

    override public bool CanSnapChild(string name)
    {
        bool CanSnap = false;


        if (name.StartsWith("Motor"))
        {
            CanSnap = true;
        }
        else if (name.StartsWith("Polia"))
        {
            CanSnap = motor;
        }
        else if (name.StartsWith("Rolamento"))
        {
            CanSnap = motor;
        }

        Debug.Log("[CaixaMotSnap] Checking if " + name + " can snap: " + CanSnap);
        return CanSnap;
    }

    void Update()
    {
        if (motor && polia && rolamento)
        {
            this.Activate();
            this.enabled = false;
        }
    }

    override public void SnapChild(string name)
    {
        if (name.StartsWith("Motor"))
        {
            motor = true;
        }
        else if (name.StartsWith("Polia"))
        {
            polia = true;
        }
        else if (name.StartsWith("Rolamento"))
        {
            rolamento = true;
        }
    }

    private void Activate()
    {
        var ovrGrabbable = GetComponent<OVRGrabbableShadow>();
        var rb = GetComponent<Rigidbody>();
        var bcs = GetComponents<BoxCollider>();

        ovrGrabbable.enabled = true;

        foreach (var bc in bcs)
        {
            bc.enabled = true;
        }

        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
