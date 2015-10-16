using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour 
{
	void Update () 
	{
		transform.Rotate(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
	}
}
