using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedrumSnap : MonoBehaviour
{
    public static bool MancalEsq_Placed;
    public static bool MancalDir_Placed;

    // Start is called before the first frame update
    void Start()
    {
        MancalDir_Placed = false;
        MancalEsq_Placed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CanSnapChild(string name)
    {

        return true;
    }

    public void SnapChild(string name)
    {

    }
}