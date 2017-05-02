using UnityEngine;
using System.Collections;

public class Destruir : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision colision){

		if (colision.gameObject.CompareTag("dron")){

			NotificationCenter.DefaultCenter().PostNotification (this, "Puntuar");

			Destroy (colision.gameObject);

		}

		Destroy (gameObject);

	}
}
