using UnityEngine;
using System.Collections;

public class CreateGUI : MonoBehaviour {
	
	private string changePassword = "";
	private string changeFirstName = "";
	private string changeLastName = "";
	private string changePicture = "";
	private string changeEmail = "";
	
	void OnGUI() 
	{
		GUI.backgroundColor =  Color.black;
		GUI.contentColor = Color.yellow;
		AutoResize (1024, 786);
		GUI.Button (new Rect (0, 0, 215, 50), "Profile");
		
		GUI.Button (new Rect (430, 0, 215, 50), "Dare!");
		
		GUI.Button (new Rect (215, 0, 215, 50), "Feed");		
		
		GUI.Button (new Rect (645, 0, 215, 50), "Edit");
		
		if (GUI.Button (new Rect (860, 0, 215, 50), "Logout"))
		{
			Debug.Log ("Clicked the button to logout");
			Application.Quit();
		}
		
		GUI.Label (new Rect (200, 200, 100, 50), "Enter first name: ");
		changeFirstName = GUI.TextField (new Rect (325, 200, 300, 50), changeFirstName);
		
		GUI.Label (new Rect (200, 300, 100, 50), "Enter last name: ");
		changeLastName = GUI.TextField (new Rect (325, 300, 300, 50), changeLastName);
		
		GUI.Label (new Rect (200, 400, 200, 50), "Enter password: ");
		changeEmail = GUI.TextField (new Rect (325, 400, 300, 50), changeEmail);
		
		GUI.Label (new Rect (200, 500, 200, 50), "Enter email: ");
		changePassword = GUI.TextField (new Rect (325, 500, 300, 50), changePassword);
		
		GUI.Label (new Rect (200, 600, 200, 50), "Choose picture: "); 
		changePicture = GUI.TextField (new Rect (325, 600, 300, 50), changePicture);
		
		if (GUI.Button (new Rect (650, 675, 150, 75), "Save")) 
		{
			Debug.Log ("Saved information");
			Application.LoadLevel("LoginScreen");
		}
	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
}
