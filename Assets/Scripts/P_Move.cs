using UnityEngine;
using System.Collections;

public class P_Move : MonoBehaviour {

	public float moveSpeed;
	Transform _myTransform;
	Vector3 newDest;
	public Transform mousePoint;
	NavMeshAgent myNA;
	bool checkDistance;
	GameObject interactObject;
	
	void Awake () 
	{
		_myTransform = transform;
		myNA = GetComponent<NavMeshAgent>();
	}

	void Update () 
	{
		if (Input.GetMouseButton(0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 20f))
			{
				if(hit.collider.name == "Navigation")
				{
					newDest = hit.point;
					checkDistance = false;
				}
				if(hit.collider.tag == "Interactable")
				{
					newDest = hit.point;
					interactObject = hit.collider.gameObject;
					checkDistance = true;
				}
			}
			myNA.SetDestination(newDest);
			
			
		}
		if(checkDistance) //if I've clicked on an object, check the remaining distance to it in order to pick it up
		{
			CollectItem(interactObject);
		}
	}
	
	void CollectItem(GameObject collectable)
	{
		if(myNA.remainingDistance < .35f && myNA.remainingDistance != 0)
		{
			interactObject.BroadcastMessage("Interact", interactObject, SendMessageOptions.DontRequireReceiver);
			Destroy(collectable);
			checkDistance = false;
		}
	}
}
