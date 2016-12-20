using UnityEngine;
using System.Collections;

public class Multiplayer : MonoBehaviour {

	void OnMouseDown() 
	{
		transform.localScale *= 0.9F;
	}
	
	void OnMouseUp()
	{
		Application.LoadLevel (4);
	}
}
