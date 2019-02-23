using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolateColour : MonoBehaviour
{
	public Material start;
	public Material end;

	void Update()
	{
		Renderer renderer = GetComponent<Renderer>();
		if (renderer != null)
		{
			float t = Mathf.PingPong(Time.time, 1.0f);
			renderer.material.color = Color.Lerp(start.color, end.color, t);
		}
	}
}
