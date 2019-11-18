using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomocaoSnap : Snapper
{
    public static bool roda;
    public static bool cubo;
    public static bool calota;
    public static bool motor;

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
        print("Checking if " + name + " can snap: " + name.StartsWith("CuboRoda"));

        if (name.StartsWith("Roda"))
        {
            return cubo;
        }
        else if (name.StartsWith("CuboRoda"))
        {
            return true;
        }
        else if (name.StartsWith("Calota"))
        {
            return roda;
        }
        else if (name.StartsWith("MotorLoc"))
        {
            return true;
        }

        return false;
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
        var bc = GetComponent<BoxCollider>();

        ovrGrabbable.enabled = true;
        bc.enabled = true;

        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
