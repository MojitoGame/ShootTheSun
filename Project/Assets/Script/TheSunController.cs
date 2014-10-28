using UnityEngine;
using System.Collections;

public class TheSunController : MonoBehaviour
{
	// Use this for initialization
	void Start () 
	{
		this.rigidbody2D.AddForce(new Vector2(100.0f,300.0f));
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
