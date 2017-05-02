using UnityEngine;
using System.Collections;

public class disparoBazzoka : MonoBehaviour {

	public GameObject bala;

	private int contadorBalas = 5; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0) && contadorBalas !=0){

			GameObject municion = Instantiate (bala, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			municion.GetComponent <Rigidbody>().AddRelativeForce(gameObject.transform.forward * 2000);
			contadorBalas --;
		}

	
	}
}
