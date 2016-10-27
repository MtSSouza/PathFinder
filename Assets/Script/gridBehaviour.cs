using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class gridBehaviour : MonoBehaviour {

	public int f;
	public int g;
	public int h;
	public List<GameObject> gridsCol = new List<GameObject> ();

	void OnMouseDown()
	{
		GameObject a = GameObject.Find ("manager") as GameObject;
		if (GameObject.FindGameObjectWithTag(a.GetComponent<ButtonUi> ().gridSelect) == null)
		{
			this.GetComponent<SpriteRenderer> ().color = new Color (255, 255, 0, 1);
			this.tag = a.GetComponent<ButtonUi> ().gridSelect;
		} else {
			Debug.Log ("The grid have a definition");
		}
	}

	public string rotine(string a)
	{
		GameObject b = 	GameObject.Find (a);
		return a;
	}

	public void SetVariables()
	{
		GameObject end = GameObject.FindGameObjectWithTag ("End");
		string[] name = this.name.Split('/');
		Debug.Log (name [0]);
		Debug.Log (name [1]);
		string[] endName = end.name.Split ('/');
		h = int.Parse (endName [0]) - int.Parse (name [0]);
		h += int.Parse (endName [1]) - int.Parse (name [1]);
		h *= 10;
	}


}
