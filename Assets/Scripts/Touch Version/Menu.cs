using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public Button start;
	public Button settings;
	public Button exit;

	void Start(){
		start = start.GetComponent<Button> ();
		settings = settings.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
	}

	void Update() {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			}
		}
	}

	public void OnMouseDown() 
	{
		transform.localScale *= 0.9F;
	}

	public void ExitPress(){
		Application.Quit ();
	}

	public void NoPress(){
		start.enabled = true;
		settings.enabled = true;
		exit.enabled = true;
	}

	public void Start1Player(){
		Application.LoadLevel (3);
	}

	public void Start2Player(){
		Application.LoadLevel (4);
	}

	public void LoadCredits(){
		Application.LoadLevel (5);
	}

	public void LoadSettings(){
		Application.LoadLevel (2);
	}
}
