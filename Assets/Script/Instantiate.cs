using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instantiate : MonoBehaviour {

	public GameObject prefab;
   
	public List<GameObject> newPath = new List<GameObject>();

	private Dictionary<string,GameObject> dt = new Dictionary<string, GameObject>();

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("rows", 6);
		PlayerPrefs.SetInt("columns",12);

        for (int i = 0; i < PlayerPrefs.GetInt("rows"); i++)
        {
			for (int j = 0; j < PlayerPrefs.GetInt("columns"); j++)
			{
				GameObject grid =  Instantiate (prefab, new Vector3 (-8.29f + j * 1.2f, 4.39f - i* 1.2f,0), Quaternion.identity) as GameObject;
           		newPath.Add(grid);
				grid.name = ((i+1).ToString () + "/" +(j+1).ToString ()).ToString ();
				dt.Add(((i+1).ToString () + "/" +(j+1).ToString ()).ToString (), grid);
			}
    	}
	}
}
