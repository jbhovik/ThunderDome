using UnityEngine;
using System.Collections;

public class ViewChange : MonoBehaviour {
	
	void start(){

	}

	void Update () {

		 if (Input.GetKey (KeyCode.Z)) {
			Vector3 temp = transform.position;
			temp.x = 0.0f;
			temp.y = 1.0f;
			temp.z = -1.2f;
			transform.position = temp; 
		}
		if (Input.GetKey (KeyCode.X)) {
			Vector3 temp = transform.position;
			temp.x = 0.0f;
			temp.y = 3.0f;
			temp.z = -8.0f;
			transform.position = temp;
		}
		if (Input.GetKey (KeyCode.C)) {
			Vector3 temp = transform.position;
			temp.x = 0.0f;
			temp.y = 4.0f;
			temp.z = -11.0f;
			transform.position = temp;
		}
	}
}
