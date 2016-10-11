using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 64; i++) {
			for (int j = 0; j < 32; j++){
                Instantiate (prefab, new Vector2 (-8.29f + i * 1.2f, 4.39f - j* 1.2f), Quaternion.identity);
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
