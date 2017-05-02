using UnityEngine;
using System.Collections;

public class iniciarDrone : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent agente;
	private GameObject personaje;

	// Use this for initialization
	void Start () {

		personaje = GameObject.Find ("Personaje");
		agente = GetComponent<UnityEngine.AI.NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		agente.SetDestination (personaje.transform.position);
	
	}
}
