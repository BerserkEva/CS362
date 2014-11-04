using UnityEngine;
using System.Collections;

public class EditGUI : MonoBehaviour {

	private string changePassword = "";
	private string changeFirstName = "";
	private string changeLastName = "";
	private string changePicture = "";
	private string changeEmail = "";

	void OnGUI() {
		
		AutoResize (1024, 786);
		if (GUI.Button (new Rect (0, 0, 215, 50), "Profile"))
		{
			Debug.Log ("Clicked the button to go to profile");
			Application.LoadLevel ("Profile");
		}
		
		if (GUI.Button (new Rect (430, 0, 215, 50), "Dare!")) 
		{
			Debug.Log ("Clicked the button to go to dares");
			Application.LoadLevel("Dare");
		}
		
		if (GUI.Button (new Rect (215, 0, 215, 50), "Feed")) 
		{
			Debug.Log ("Clicked the button to go to feed");
			Application.LoadLevel("Feed");
		}
		
		GUI.Button (new Rect (645, 0, 215, 50), "Edit");

		if (GUI.Button (new Rect (860, 0, 215, 50), "Logout"))
		{
			Debug.Log ("Clicked the button to logout");
			Application.Quit();
		}

		GUI.Label (new Rect (200, 200, 100, 50), "Change first name: ");
		changeFirstName = GUI.TextField (new Rect (325, 200, 300, 50), changeFirstName);

		GUI.Label (new Rect (200, 300, 100, 50), "Change last name: ");
		changeLastName = GUI.TextField (new Rect (325, 300, 300, 50), changeLastName);

		GUI.Label (new Rect (200, 400, 200, 50), "Change password: ");
		changeEmail = GUI.TextField (new Rect (325, 400, 300, 50), changeEmail);

		GUI.Label (new Rect (200, 500, 200, 50), "Change email: ");
		changePassword = GUI.TextField (new Rect (325, 500, 300, 50), changePassword);

		GUI.Label (new Rect (200, 600, 200, 50), "Change picture: "); 
		changePicture = GUI.TextField (new Rect (325, 600, 300, 50), changePicture);

		if (GUI.Button (new Rect (650, 675, 150, 75), "Save"))
						Debug.Log ("Saved information");	
	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
}
