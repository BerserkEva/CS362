using UnityEngine;
using System.Collections;

public class FeedGUI : MonoBehaviour {


	public GUIText Score;
	public GUIText dare;
	
	private int score;
	private int dareSkip;

	private string[] dares = new string[] {"Got to do your home.", "Apply for a job", "Cook a meal", "Go on a date.", "Try spicy food","Go skydiving"}; 

	static private int length;
	static public int dareNumber;

	void UpdateScore()
	{
		Score.text = "Score: " + score;
	}
	
	void UpdateDare()
	{
		dare.text = "Dare: " + dares[dareNumber];
	}
	
	void Start()
	{
		score = 0;
		length = dares.Length;
		dareSkip = 0;
		dareNumber = 0; 

		UpdateScore ();
		UpdateDare ();
	}

	void FixedUpdate()
	{
		Debug.Log (dareNumber);
		dareNumber = Random.Range(0, length);
	}
	
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
		
		GUI.Button (new Rect (215, 0, 215, 50), "Feed");
	
		
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

		if(GUI.Button (new Rect (400, 500, 225, 150), "BS!!!!"))
			AddScore (-10);
		
		if (GUI.Button (new Rect (100, 500, 225, 150), "Fist Bump"))
			AddScore (10);
		
		if (GUI.Button (new Rect (700, 500, 225, 150), "Next"))
		{
			dareSkip += 1;

			if(dareSkip < 3)
				newDare ();

			else
				return;

		}
	}
	
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}
	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	public void newDare()
	{
		dare.text = dares [dareNumber];
		UpdateDare ();
	}
}
