using UnityEngine;
using System.Collections;

public class generarDrone : MonoBehaviour {

	public GameObject drone;

	// Use this for initialization
	void Start () {

		crearObjeto ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void crearObjeto(){

		GameObject clonDrone = Instantiate (drone, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
	}
}
