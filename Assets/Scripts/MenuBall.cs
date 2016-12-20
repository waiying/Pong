using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour {

	public int ballVel = 500;
	public Rigidbody rb;

	void Awake()//called once when the object is created. We don't use start b/c the balls are going to be created when player clicks.
	{
		rb.velocity = new Vector3 (ballVel, ballVel, 0);
	}
}
		