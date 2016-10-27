using UnityEngine;
using System.Collections;

public class ButtonUi : MonoBehaviour {

	public string gridSelect;

	public void SetStartGrid()
	{
		gridSelect = "Start";
	}
	public void SetEndGrid()
	{
		gridSelect = "End";
	}
	public void BestWay()
	{
		GameObject.FindGameObjectWithTag ("Start").GetComponent<gridBehaviour> ().SetVariables ();
	}
}
