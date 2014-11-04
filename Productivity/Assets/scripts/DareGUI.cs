using UnityEngine;
using System.Collections;

public class DareGUI : MonoBehaviour {

	public GUIText currentDare;
	public GUIText dareTime;

	public GUIStyle myGUIStyle;

	private string caption = "";

	private bool submit = false;
	private bool chosen = true;

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

		if(chosen)
		{
			currentDare.enabled = false;
			dareTime.enabled = false;
			GUI.Label (new Rect (100, 125, 100, 50), "Choose Dare:");
				
			if(GUI.Button (new Rect (100, 150, 225, 150), "Dare 1"))
			{
				Debug.Log("Dare 1 chosen");
				submit = true;
				chosen = false;
			}
			if(GUI.Button (new Rect (400, 150, 225, 150), "Dare 2"))
			{
				Debug.Log("Dare 2 chosen");
				submit = true;
				chosen = false;
			}
			if(GUI.Button (new Rect (700, 150, 225, 150), "Dare 3"))
			{
				Debug.Log("Dare 3 chosen");
				submit = true;
				chosen = false;
			}
			//chosen = true;
		}

		if (submit)
		{
			dareTime.enabled = true;
			currentDare.enabled = true;
			GUI.Label (new Rect (100, 400, 100, 50), "Current Dare:");
			currentDare.transform.position = new Vector2 (0.185f, 0.47f);
			currentDare.text = "Your current dare here.";

			GUI.Label (new Rect (100, 465, 75, 50), "Time");
			dareTime.transform.position = new Vector2 (0.14f, 0.4f);
			dareTime.text = "Your Due date.";

			GUI.Label (new Rect (100, 550, 100, 25), "Choose a photo:");
			GUI.Label (new Rect (100, 575, 100, 25), "Caption: ");
			caption = GUI.TextField (new Rect (100, 600, 200, 50), caption);

			if(GUI.Button (new Rect (100, 675, 100, 50), "Submit Date "))
			{
				chosen = true;
				submit = false;
			}
		}

	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
}
