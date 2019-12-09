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
        dict.Add("MancalEsq", Tuple.Create("Mancal Esquerdo", "", 0));
        dict.Add("MancalDir", Tuple.Create("Mancal Direito", "", 1));
    }

    private void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     RaycastHit hit;
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //     if (Physics.Raycast(ray, out hit, 100.0f))
        //     {
        //         if (hit.transform != null)
        //         {
        //             print(hit.transform.gameObject.name);

        //             GetComponent<Text>().text = "Object: " + dict[hit.transform.gameObject.name.ToString()].Item1 + "\nInformation: " + dict[hit.transform.gameObject.name.ToString()].Item2;
        //             rawImage.texture = arrayImages[dict[hit.transform.gameObject.name.ToString()].Item3];
        //         }
        //     }
        // }
    }

    public void UpdateDesc(string name)
    {
        if (!dict.ContainsKey(name))
        {
            return;
        }

        GetComponent<Text>().text = dict[name].Item1 + "\n" + dict[name].Item2;

        if (arrayImages.Length > dict[name].Item3)
        {
            rawImage.texture = arrayImages[dict[name].Item3];
        }
    }

    public void Reset()
    {

    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
