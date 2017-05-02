using UnityEngine;
using System.Collections;

public class generar : MonoBehaviour {

	public GameObject Drone;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < Random.Range(2, 5); i++){

			Instantiate (Drone , gameObject.transform.position, gameObject.transform.rotation);
		
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
