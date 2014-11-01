using UnityEngine;
using System.Collections;
 
[System.Serializable]
public class ProfileGUI : MonoBehaviour {

	public string LoginString = "comments";

	void OnGUI()
	{

		LoginString = GUI.TextField (new Rect(200, 200, 200, 100), LoginString, 30);

		GUIStyle textFieldStyle = new GUIStyle ();

		AutoResize (1024, 786);
		GUI.Button (new Rect (0, 0, 215, 50), "Profile");
		{
			textFieldStyle.normal.textColor = new Color (255, 215, 51, 0);
		}
		
		if (GUI.Button (new Rect (430, 0, 215, 50), "Dare!")) 
		{
			GUI.color =new Color  (255, 215, 51, 0);
			Debug.Log ("Clicked the button to go to dares");
			Application.LoadLevel("Dare");
		}
		
		if (GUI.Button (new Rect (215, 0, 215, 50), "Feed")) 
		{
			textFieldStyle.normal.textColor = new Color (255, 215, 51, 0);
			Debug.Log ("Clicked the button to go to feed");
			Application.LoadLevel("Feed");
		}
		
		if (GUI.Button (new Rect (645, 0, 215, 50), "Edit")) 
		{
			GUI.color = new Color (255, 215, 51, 0);
			Debug.Log ("Clicked the button to edit");
			Application.LoadLevel("Edit");
		}

		if (GUI.Button (new Rect (860, 0, 215, 50), "Logout"))
		{
			GUI.color = new Color (255, 215, 51, 0);
			Debug.Log ("Clicked the button to logout");
			Application.Quit();
		}

	}

	/*void Update()
	{
		UpdateScore ();
		UpdateDare ();
	}*/

	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}


}
