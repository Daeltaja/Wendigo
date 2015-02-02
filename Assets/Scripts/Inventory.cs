using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public static int berries, nuts, stones;
	
	public static void ChangeStock(int berry, int nut, int stone)
	{
		berries += berry;
		nuts += nut;
		stones += stone;
	}
	
	public static int TotalStock()
	{
		int stocks = berries + nuts + stones;
		return stocks;
	}
}
