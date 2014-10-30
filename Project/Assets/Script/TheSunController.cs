using UnityEngine;
using System.Collections;

public class TheSunController : MonoBehaviour
{
	private int angryLevel = 0;
	private int baseForceValue = 300;
	void Start () 
	{
		ForceTheSun();
	}
	
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Alpha1))
		{
			angryLevel++;
			ForceTheSun();
		}
	}
	private void ForceTheSun()
	{
		this.rigidbody2D.AddForce(GetForceVector());
	}

	private Vector2 GetForceVector()
	{
		int forceX = Random.RandomRange(- (baseForceValue +angryLevel * 100) , baseForceValue +angryLevel * 100);
		int forceY = Random.RandomRange(- (baseForceValue +angryLevel * 100) , baseForceValue +angryLevel * 100);
		return new Vector2(forceX,forceY);
	}
}
