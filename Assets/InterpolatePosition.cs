using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolatePosition : MonoBehaviour
{
	public Transform start;
	public Transform end;

	void Update()
	{
		float t = Mathf.PingPong(Time.time, 1.0f);
		transform.position = Vector3.Lerp(start.position, end.position, t);
	}
}
