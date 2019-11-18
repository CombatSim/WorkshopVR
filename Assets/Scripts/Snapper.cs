using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Snapper : MonoBehaviour
{
    abstract public bool CanSnapChild(string name);

    abstract public void SnapChild(string name);
}
