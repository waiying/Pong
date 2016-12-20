using UnityEngine;
using System.Collections;

public class PaddleTouch2 : MonoBehaviour {

	public Vector3 playerPos;
	public GameObject paddle1;
	public GameObject paddle2;
	public float mousePos;
	Ray ray;
	RaycastHit rayCH;
	//public LayerMask touchInputMask;
	
	// Update is called once per frame
	void Update () {
	
#if UNITY_EDITOR
		if (Input.GetMouseButton(0)) {
			mousePos = Input.mousePosition.x;
			if (Input.mousePosition.x < 278) {
				ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out rayCH)) {
					playerPos = new Vector3 (-20, Mathf.Clamp (rayCH.point.y, -12.7F, 12.7F), 0);
					paddle1.transform.position = playerPos;
				}
			}
			else {
				ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out rayCH)) {
					playerPos = new Vector3 (20, Mathf.Clamp (rayCH.point.y, -12.7F, 12.7F), 0);
					paddle2.transform.position = playerPos;
				}
			}
		}
#endif
		if (Input.touchCount > 0) {
			foreach (Touch touch in Input.touches){
				if (touch.position.x < 278) {
					ray = Camera.main.ScreenPointToRay (touch.position);
					if (Physics.Raycast (ray, out rayCH)) {
						playerPos = new Vector3 (-20, Mathf.Clamp (rayCH.point.y, -12.7F, 12.7F), 0);
						paddle1.transform.position = playerPos;
					}
				}
				else {
					ray = Camera.main.ScreenPointToRay (touch.position);
					if (Physics.Raycast (ray, out rayCH)) {
						playerPos = new Vector3 (20, Mathf.Clamp (rayCH.point.y, -12.7F, 12.7F), 0);
						paddle2.transform.position = playerPos;
					}
				}
			}
		}
	}
}