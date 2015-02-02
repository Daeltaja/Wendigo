using UnityEngine;
using System.Collections;

public class P_Stats : MonoBehaviour {

	public static float hunger, cold;
	bool isAlive = true;

	void Update () 
	{	
		if(isAlive)
		{
			hunger+=Time.deltaTime;
			cold+=Time.deltaTime;
		}
		if(hunger <= 0)
		{
			hunger = 0;
		}
		if(cold <= 0)
		{
			cold = 0;
		}
	}
}
