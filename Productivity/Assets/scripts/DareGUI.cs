﻿using UnityEngine;
using System.Collections;

public class DareGUI : MonoBehaviour {

	
	void OnGUI() {
		
		AutoResize (1024, 786);
		if (GUI.Button (new Rect (0, 0, 215, 50), "Profile"))
		{
			Debug.Log ("Clicked the button to go to profile");
			Application.LoadLevel ("Profile");
		}
		
		GUI.Button (new Rect (430, 0, 215, 50), "Dare!");
	
		
		if (GUI.Button (new Rect (215, 0, 215, 50), "Feed")) 
		{
			Debug.Log ("Clicked the button to go to feed");
			Application.LoadLevel("Feed");
		}
		
		if (GUI.Button (new Rect (645, 0, 215, 50), "Edit")) 
		{
			Debug.Log ("Clicked the button to edit");
			Application.LoadLevel("Edit");
		}
		
		if (GUI.Button (new Rect (860, 0, 215, 50), "Logout"))
		{
			Debug.Log ("Clicked the button to logout");
			Application.Quit();
		}
	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
}