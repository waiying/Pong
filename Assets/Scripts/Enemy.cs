using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed = 8.6f;
	Vector2 targetPos;
	Vector2 playerPos;
	GameObject ballObj;
	void Awake () {
		if (SettingsMenu.diff_press == 0) {
			speed = 8.3f;
		}
		if (SettingsMenu.diff_press == 1) {
			speed = 10f;
		}
		if (SettingsMenu.diff_press == 2) {
			speed = 12.7f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
		if(ballObj != null){
			targetPos = Vector2.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
			playerPos = new Vector2 (-20, Mathf.Clamp (targetPos.y, -12.7F, 12.7F));
			gameObject.transform.position = new Vector2 (20, playerPos.y);
		}
	}
}
