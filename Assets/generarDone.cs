using UnityEngine;
using System.Collections;

public class generarDone : MonoBehaviour {

	public GameObject drone;
	
	// Use this for initialization
	void Start () {

		for (int i =0; i< Random.Range(1,5); i++){

			Instantiate (drone);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
