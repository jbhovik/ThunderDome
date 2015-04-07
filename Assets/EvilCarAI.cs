using UnityEngine;
using System.Collections;

public class EvilCarAI : MonoBehaviour {

	public string chaseState;
	
	// Use this for initialization
	void Start () {
		chaseState = "rotating";
	}
	
	// Update is called once per frame
	void Update () {
		//FacePlayer ();
	}
	
	void FacePlayer(){
		Vector3 targetDir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
		Vector3 forward = transform.forward;;
		if (chaseState.Equals ("rotating")) {
			float angle = Vector3.Angle (targetDir, forward);
			Quaternion newRotation = Quaternion.LookRotation(targetDir);
			transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 1.0f);
			chaseState = "moving";
		} else if (chaseState.Equals ("moving")) {
			Vector3 startPosition = transform.position;
			Vector3 endPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
			float speed = 100.0f;
			transform.position = Vector3.Lerp(startPosition, endPosition, speed * Time.deltaTime);
			chaseState = "rotating";
		}
	}
}
