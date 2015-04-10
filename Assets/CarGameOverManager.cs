using UnityEngine;
using System.Collections;

public class CarGameOverManager : MonoBehaviour {

	public GameObject car;
	public float restartDelay;
	Animator anim;
	float restartTimer;
	// Use this for initialization
	void Start () {
		restartDelay = 5f;
	}

	void Awake(){
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "EnemyCar") {
			anim.SetTrigger("CarGameOver");

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay){
				Application.LoadLevel(Application.loadedLevel);
			}
			

		}
	}
}
