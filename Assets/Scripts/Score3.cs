using UnityEngine;
using System.Collections;

public class Score3 : MonoBehaviour {

	public TextMesh currSco;
	public GameObject ballPref;
	public GameObject status;
	public GameObject restart;
	GameObject ball;
	public Transform paddleObj;
	int score;
	
	// Update is called once per frame
	void Update () {

		ball = GameObject.FindGameObjectWithTag ("Ball");
		currSco.text = "" + score; //concatenation converts score to a string
		if (score > 9) {
			currSco.transform.position = new Vector3 (-8, 13, 0);
		}
	}


	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Ball") {
			score += 1;
			Destroy (ball);
			if (score < SettingsMenu.win_press) {
				(Instantiate (ballPref, new Vector3 (paddleObj.transform.position.x - 2, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;
			}

			else {
				Instantiate (status, new Vector3 (-16.6F, -3.5F, 0), Quaternion.identity);
				var go = Instantiate (restart, new Vector3 (-7.5F, -10, 0), Quaternion.identity) as GameObject;
				go.AddComponent<Multiplayer>();
				go.AddComponent<BoxCollider>();
			}
		}
	}



}
