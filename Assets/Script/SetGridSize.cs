using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SetGridSize : MonoBehaviour {

	public int a;
	public int b;

	
	public void setGrid()
	{
		string f = GameObject.Find ("Text1").GetComponent<Text> ().text;
		string e = GameObject.Find ("Text").GetComponent<Text> ().text;
		a =  int.Parse (f);
		b = int.Parse (e);
		PlayerPrefs.SetInt ("rows",a);
		PlayerPrefs.SetInt ("columns", b);
	}
}
