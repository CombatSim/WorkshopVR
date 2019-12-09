using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fader : MonoBehaviour
{
    public GameObject refY;

    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        this.originalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = new Color(originalColor.r, originalColor.g, originalColor.b, refY.transform.localPosition.y);
    }
}
