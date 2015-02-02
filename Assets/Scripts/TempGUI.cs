using UnityEngine;
using System.Collections;

public class TempGUI : MonoBehaviour {

	public Texture red, blue;

	void OnGUI()
	{
		if(GUI.Button (new Rect(10,10,80,30), "Berries: " +Inventory.berries))
		{
			if(Inventory.berries > 0)
			{
				Inventory.ChangeStock(-1, 0, 0);
				P_Stats.hunger -= 5;	
			}
		}
		if(GUI.Button (new Rect(10,50,80,30), "Nuts: " +Inventory.nuts))
		{
			if(Inventory.nuts > 0)
			{
				Inventory.ChangeStock(0, -1, 0);
				P_Stats.hunger -= 3;
			}
		}
		if(GUI.Button (new Rect(10,90,80,30), "Stones: " +Inventory.stones))
		{
			if(Inventory.stones > 0)
			Inventory.ChangeStock(0, 0, -1);
		}
		
		GUI.DrawTexture (new Rect(10, 130, P_Stats.hunger, 20), red);
		GUI.DrawTexture (new Rect(10, 160, P_Stats.cold, 20), blue);
		GUI.Label (new Rect(15, 130, 300, 30), "Hunger");
		GUI.Label (new Rect(15, 160, 300, 30), "Temp");
	}
}
