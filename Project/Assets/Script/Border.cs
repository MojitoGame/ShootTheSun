using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour
{
	private GameObject theSun;
	void Awake()
	{
		theSun = GameObject.Find("TheSun");
	}
	void OnCollisionEnter2D()
	{
	}
}
