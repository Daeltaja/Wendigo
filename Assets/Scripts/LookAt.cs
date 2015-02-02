using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	public Transform m_Camera;
	Vector3 myPos;
	
	void Start()
	{
		transform.GetChild(0).transform.renderer.castShadows = true;
	}
	
	void Update()
	{
		Vector3 lookie = m_Camera.transform.position;
		lookie.y = 0;
		transform.LookAt(lookie);
	}
}
