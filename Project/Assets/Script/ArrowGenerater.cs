using UnityEngine;
using System.Collections;

public class ArrowGenerater : MonoBehaviour 
{
	public GameObject arrowPrefab;

	void Update ()
	{
		if(Input.touchCount == 1)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began)
			{
				Debug.Log(string.Format("Generate a arrow at {0}",touch.position));
			}
		}
		else if(Input.GetMouseButtonDown(0))
		{
			if(arrowPrefab != null)
			{
				Instantiate(arrowPrefab,Camera.main.ScreenToWorldPoint(Input.mousePosition) ,arrowPrefab.transform.rotation);
				Debug.Log(string.Format("Generate a arrow at {0}",Input.mousePosition));
			}
		}
	}

}
