using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {

	CameraCode camCode;
	public Vector3 newLerpTo;

	void OnTriggerEnter(Collider other)
	{
		if(other.collider.name == "Player")
		{
			camCode.NewLerpTo(newLerpTo);
		}
	}
	
	void Start ()
	{
		camCode = Camera.main.GetComponent<CameraCode>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
