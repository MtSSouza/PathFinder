using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("rows", 13);
		PlayerPrefs.SetInt("columns",6);

		for (int i = 0; i < PlayerPrefs.GetInt("rows"); i++) {
			for (int j = 0; j < PlayerPrefs.GetInt("columns"); j++){
               GameObject grid =  Instantiate (prefab, new Vector2 (-8.29f + i * 1.2f, 4.39f - j* 1.2f), Quaternion.identity) as GameObject;
				grid.name = "grid "+ (i.ToString() + j.ToString()).ToString(); 
			}
		}

	}
    void OnMouseDown(Collider2D col)
    {
        if (col.tag.Equals("prefab"))
        {
            Debug.Log("sadfsdfs");
            prefab.GetComponent<SpriteRenderer>().color = new Vector4(1, 0, 1, 1);
        }
    }

	// Update is called once per frame
    void Update()
    {

        
    }
}
