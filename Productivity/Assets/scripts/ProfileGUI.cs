using UnityEngine;
using System.Collections;
 
[System.Serializable]
public class ProfileGUI : MonoBehaviour {

	void onGUI()
	{
		if(GUI.Button (new Rect (500, 500, 100, 100), "BS!!!!"))
			Debug.Log ("Clicked button to BS someone");
	}

}
