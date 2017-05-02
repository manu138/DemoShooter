using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public GameObject bala;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){

			GameObject municion = Instantiate (bala, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			Rigidbody rigBala = municion.GetComponent<Rigidbody> ();
			rigBala.AddForce( gameObject.transform.forward *5000);
		
		}
	
	}
}
