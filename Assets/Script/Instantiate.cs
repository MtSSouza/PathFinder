using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instantiate : MonoBehaviour {

	public GameObject prefab;
    private List<GameObject> newPath = new List<GameObject>();
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("rows", 13);
		PlayerPrefs.SetInt("columns",6);

        for (int i = 0; i < PlayerPrefs.GetInt("columns"); i++)
        {
			for (int j = 0; j < PlayerPrefs.GetInt("rows"); j++){
               GameObject grid =  Instantiate (prefab, new Vector2 (-8.29f + i * 1.2f, 4.39f - j* 1.2f), Quaternion.identity) as GameObject;
               newPath.Add(grid);
               grid.name = "grid " + newPath.Count; /*(i.ToString() + j.ToString()).ToString()*/
                
			    }
		    }
	    }

	// Update is called once per frame
    void Update()
    {

        
    }
}
