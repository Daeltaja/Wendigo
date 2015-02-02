using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {

	public enum InteractiveObjects { NA, berry, nut, stone };
	public InteractiveObjects whichObject;
	
	void Interact(GameObject interactObject)
	{
		if(whichObject == InteractiveObjects.berry)
		{
			Inventory.ChangeStock(1, 0, 0);
		}
		if(whichObject == InteractiveObjects.nut)
		{
			Inventory.ChangeStock(0, 1, 0);
		}
		if(whichObject == InteractiveObjects.stone)
		{
			Inventory.ChangeStock(0, 0, 1);
		}
	}
}
