using UnityEngine;
using System.Collections;

public class CameraCode : MonoBehaviour {
	
	Vector3 target;
	bool lerping;
	GameObject player;
	
	void Start()
	{
		player = GameObject.Find ("Player");
	}
	
	void Update () 
	{
		target = player.transform.position;
		Vector3 myTrans = transform.position;
		
		myTrans.x = Mathf.Lerp(myTrans.x, target.x+2f, 2f * Time.deltaTime);
		transform.position = myTrans;
	
		//if(lerping)
		//transform.position = Vector3.Lerp(transform.position, target, .5f * Time.deltaTime);
	}
	
	public void NewLerpTo(Vector3 lerpTo)
	{
		target = lerpTo;
		lerping = true;
	}
}
