using UnityEngine;
using System.Collections;

public class Ball2: MonoBehaviour {

	public float ballVelocity = 30;
	//Rigidbody is unity's physics system.
	Rigidbody2D rb;
	float time ;
	public Vector2 currVelocity;
	ClickManager doubleClick = new ClickManager();
	bool isPlay; //true when ball is moving. false when ball isn't moving.
	int randInt; //when they click for the first time, we want the ball to go in a random direction.
	//Void Start() is called when game is loaded. Void Awake() is called when the ball is created. Important for when score increases and respawn the ball
	void Awake () {
		time = Time.time;
		rb = gameObject.GetComponent<Rigidbody2D> ();
		randInt = Random.Range (1, 3);
		//ballVelocity = 1700;
		if (SettingsMenu.diff_press == 0) {
			ballVelocity = 30;
		}
		if (SettingsMenu.diff_press == 1) {
			ballVelocity = 38;
		}
		if (SettingsMenu.diff_press == 2) {
			ballVelocity = 46;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlay == true) {
			rb.velocity = rb.velocity.normalized * ballVelocity;
			currVelocity = rb.velocity;
			if (time + 10 < Time.time){
				time = time + 10;
				ballVelocity = ballVelocity + 6;
				rb.velocity = rb.velocity.normalized * (ballVelocity);
			}
		}
		
		if(Input.GetMouseButton(0) == true && isPlay == false)
		{
			if(doubleClick.DoubleClick()){
				transform.parent = null;
				isPlay = true;
				rb.isKinematic = false;
				if(randInt == 1)
				{
					rb.velocity = new Vector2(-1,1) * ballVelocity;
					//rb.AddForce(new Vector2(ballVelocity, ballVelocity),0);
				}
				if(randInt == 2)
				{
					rb.velocity = new Vector2(-1,-1) * ballVelocity;
					//rb.AddForce(new Vector2(ballVelocity, -ballVelocity),0);
				}
			}
		}
	}
	
	float hitFactor (Vector2 ballPos, Vector2 paddlePos, float paddleHeight){
		return (ballPos.y - paddlePos.y) / paddleHeight;
	}
	
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.name == "Paddle") {
			float y = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.y);
			if (y > 0.2f){
				Vector2 dir = new Vector2 (1, 1).normalized;
				rb.velocity = dir * ballVelocity;
			}
			
			else if (y < -0.2f) {
				Vector2 dir = new Vector2 (1, -1).normalized;
				rb.velocity = dir * ballVelocity;
			}
			
			else {
				Vector2 dir = new Vector2 (1, y).normalized;
				rb.velocity = dir * ballVelocity;
			}
		}
		
		if (col.gameObject.name == "Enemy") {
			float y = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.y);
			
			if (y > 0.1f){
				Vector2 dir = new Vector2 (-1, 1).normalized;
				rb.velocity = dir * ballVelocity;
			}
			
			else if (y < -0.1f) {
				Vector2 dir = new Vector2 (-1, -1).normalized;
				rb.velocity = dir * ballVelocity;
			}
			
			else {
				Vector2 dir = new Vector2 (-1, y).normalized;
				rb.velocity = dir * ballVelocity;
			}
		}
	}
}