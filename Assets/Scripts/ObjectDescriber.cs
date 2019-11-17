using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDescriber : MonoBehaviour
{
	private Hashtable objectDescriptions = new Hashtable();


	private void Start()
	{
		objectDescriptions.Add("Cube", "Connect with the sphere or the Cylinder");
		objectDescriptions.Add("Sphere", "Connect with the Cube");
		objectDescriptions.Add("Cylinder", "Connect with the Cube");
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
					GetComponent<Text>().text = "Object: " + hit.transform.gameObject.name.ToString() + "\nInformation: " + objectDescriptions[hit.transform.gameObject.name.ToString()];

				}
			}
		}
	}

	private void PrintName(GameObject go)
	{
		print(go.name);
	}
}
