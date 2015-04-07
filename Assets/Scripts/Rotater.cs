using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 3, 0));
		DodgeCar ();
	}

	void DodgeCar(){
		Vector3 gasCanVector = GameObject.FindGameObjectWithTag ("Player").transform.position - transform.position;
		double length = gasCanVector.magnitude;
		Vector3 localForward = transform.worldToLocalMatrix.MultiplyVector(transform.forward);
		Debug.DrawLine(localForward, GameObject.FindGameObjectWithTag("Player").transform.position);
		if (length < 11.0) {
//			v = P2 - P1
//				
//				P3 = (-v.y, v.x) / Sqrt(v.x^2 + v.y^2) * h
//					
//					P4 = (-v.y, v.x) / Sqrt(v.x^2 + v.y^2) * -h

			Vector3 gasCanVector2 = GameObject.FindGameObjectWithTag ("Player").transform.forward;
			Vector3 startPosition = transform.position;
			Vector3 perp = new Vector3(-gasCanVector2.z, gasCanVector2.y, gasCanVector2.x);

			Debug.DrawLine(startPosition, perp);
			//Vector3 endPosition = Vector3.Cross(gasCanVector2, Vector3.up);
			float speed = 1.0f;
			transform.position = Vector3.Lerp(startPosition, perp, speed * Time.deltaTime);
		} else {
			//Debug.Log ("Far");
		}
	}
}
