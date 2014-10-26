using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GUI.Button(new Rect(10, 10, 50, 50));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Texture btnTexture;
	void OnGUI() {
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (GUI.Button(new Rect(0, 0, 215, 50), "Profile"))
			Debug.Log("Clicked the button to go to profile");
		
		if (GUI.Button(new Rect(430, 0, 215, 50), "Dare!"))
			Debug.Log("Clicked the button to go to dares");

		if (GUI.Button(new Rect(215, 0, 215, 50), "Feed"))
			Debug.Log("Clicked the button to go to feed");

		if (GUI.Button(new Rect(645, 0, 215, 50), "Edit"))
			Debug.Log("Clicked the button to edit");

		if (GUI.Button(new Rect(860, 0, 215, 50), "Logout"))
			Debug.Log("Clicked the button to logout");
		
	}
}
