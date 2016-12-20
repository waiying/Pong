using UnityEngine;
using System.Collections;

public class PaddleTouch : MonoBehaviour {
	
	public Vector3 playerPos;
	Ray ray;
	RaycastHit rayCH;
	//public LayerMask touchInputMask;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out rayCH)) {
				playerPos = new Vector3 (-20, Mathf.Clamp (rayCH.point.y, -12.7F, 12.7F), 0);
				gameObject.transform.position = playerPos;
			}
		}
	}
}
