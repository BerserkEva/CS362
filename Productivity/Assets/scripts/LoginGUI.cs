using UnityEngine;
using System.Collections;

public class LoginGUI : MonoBehaviour {

	private string LoginString = "";
	private string password = "";
	public GUIStyle textFieldStyle = new GUIStyle ();

	private bool show = true;
//	private bool create = false;
	private bool userHasHitReturn = false;

	void OnGUI()
	{
		GUI.backgroundColor =  Color.black;
		GUI.contentColor = Color.yellow;
		Event e = Event.current;
		AutoResize (1024, 786);
		GUI.Button (new Rect (0, 0, 215, 50), "Profile");

		GUI.Button (new Rect (430, 0, 215, 50), "Dare!");
	
		GUI.Button (new Rect (215, 0, 215, 50), "Feed");
	
		GUI.Button (new Rect (645, 0, 215, 50), "Edit");

		if (show) 
		{

			if (GUI.Button (new Rect (350, 300, 300, 100), "Login")) 
			{
				Debug.Log ("Clicked the button to login");
				show = false;
			}

			if (GUI.Button (new Rect (350, 500, 300, 100), "Create Account")) 
			{
				Debug.Log ("Create an account");
				//show = false;
				Application.LoadLevel("Create");
			}
		}



		if (!show) 
		{
			GUI.Label(new Rect(300, 375, 75, 25), "User name: ");
			GUI.Label(new Rect(300, 450, 75, 25), "Password: ");
			LoginString = GUI.TextField (new Rect (400, 350, 250, 75), LoginString, 30);
			password = GUI.TextField (new Rect (400, 425, 250, 75), password, 30);
			if(e.keyCode == KeyCode.Return)
			{
				userHasHitReturn = true;
			}

			if(userHasHitReturn)
				Application.LoadLevel("Profile");
		}
	
		if (GUI.Button (new Rect (860, 0, 215, 50), "Logout")) 
		{
			Debug.Log ("Clicked the button to logout");
			Application.Quit ();
		}
	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
}
