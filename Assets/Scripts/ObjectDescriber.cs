using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDescriber : MonoBehaviour
{
    public Texture[] arrayImages;
    public RawImage rawImage;

    Dictionary<string, Tuple<string, string, int>> dict = new Dictionary<string, Tuple<string, string, int>>();

    private void Start()
    {
        dict.Add("MancalEsq", Tuple.Create("Mancal Esquerdo", "Serve para blabla", 0));
        dict.Add("MancalDir", Tuple.Create("Mancal Direito", "Serve para blabla", 1));
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    print(hit.transform.gameObject.name);

                    GetComponent<Text>().text = "Object: " + dict[hit.transform.gameObject.name.ToString()].Item1 + "\nInformation: " + dict[hit.transform.gameObject.name.ToString()].Item2;
                    rawImage.texture = arrayImages[dict[hit.transform.gameObject.name.ToString()].Item3];
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
