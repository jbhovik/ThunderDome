using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	float speed;

	void start(){
		speed = 5.0f;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 3, 0));
		DodgeCar ();
	}

	void DodgeCar(){
		Vector3 gasCanVector = transform.localPosition - GameObject.FindGameObjectWithTag ("Player").transform.localPosition;
		Vector3 forward = GameObject.FindGameObjectWithTag("Player").transform.forward;

		Vector3 farForward = new Vector3 (forward.x * 20, forward.y * 20, forward.z * 20);
		Vector3 perp = new Vector3(-forward.z, forward.y, forward.x);

		Vector3 farPerp = new Vector3(perp.x * 20, perp.y * 20, perp.z * 20);
		//transform.Translate (farForward, transform);
		//transform.Translate (-farPerp);
		Debug.DrawLine(forward, farPerp);
		Debug.DrawLine (forward, farForward);
		//Debug.DrawLine(far, forward);
		double length = gasCanVector.magnitude;
		if (length < 10.0) {

			//Debug.DrawLine(forward, perp);
			Vector3 startPos = transform.localPosition;
			Vector3 endPos = perp - startPos;

			Debug.DrawLine(startPos, farPerp);
			farPerp.Normalize();
			transform.Translate(farPerp * .2f);
			//Vector3 endPosition = Vector3.Cross(gasCanVector2, Vector3.up);
			//float speed = 0.1f;
			//transform.position = Vector3.Lerp(startPos, farPerp, speed * Time.deltaTime);
		} else {
			//Debug.Log ("Far");
		}
	}
}
