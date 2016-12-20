using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void Update() {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.LoadLevel(1);
			}
		}
	}

	void OnMouseDown() {
		transform.localScale *= 0.9F;
	}
	
	void OnMouseUp() {
		Application.LoadLevel(1);
	}
}
