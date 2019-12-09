using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomocaoSnap : Snapper
{
    private bool roda;
    private bool cubo;
    private bool calota;
    private bool motor;

    // Start is called before the first frame update
    void Start()
    {
        roda = false;
        cubo = false;
        calota = false;
        motor = false;
    }

    override public bool CanSnapChild(string name)
    {
        bool CanSnap = false;

        if (name.StartsWith("Roda"))
        {
            CanSnap = cubo;
        }
        else if (name.StartsWith("CuboRoda"))
        {
            CanSnap = true;
        }
        else if (name.StartsWith("Calota"))
        {
            CanSnap = roda;
        }
        else if (name.StartsWith("MotorLoc"))
        {
            CanSnap = true;
        }

        Debug.Log("[LocSnap] Checking if " + name + " can snap: " + CanSnap);
        return CanSnap;
    }

    void Update()
    {
        if (roda && cubo && calota && motor)
        {
            this.Activate();
            this.enabled = false;
        }
    }

    override public void SnapChild(string name)
    {
        if (name.StartsWith("Roda"))
        {
            roda = true;
        }
        else if (name.StartsWith("CuboRoda"))
        {
            cubo = true;
        }
        else if (name.StartsWith("Calota"))
        {
            calota = true;
        }
        else if (name.StartsWith("MotorLoc"))
        {
            motor = true;
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
