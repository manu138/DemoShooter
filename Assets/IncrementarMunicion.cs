using UnityEngine;
using System.Collections;

public class IncrementarMunicion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision colision){
		
		if (colision.gameObject.name == "Personaje"){

			Destroy (gameObject);
			
			NotificationCenter.DefaultCenter().PostNotification (this, "ObtenerMunicion");

		}
		
	}
}
