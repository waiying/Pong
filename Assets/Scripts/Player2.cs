using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float paddleSpeed = 1;
	public Vector3 playerPos;
	
	// Update is called once per frame
	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical2") * paddleSpeed); //Input means get the up-down or s-w arrows from player
		playerPos = new Vector3 (20, Mathf.Clamp (yPos, -12.7F, 12.7F), 0);
		gameObject.transform.position = playerPos;
	}
}
