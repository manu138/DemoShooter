using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject bala;
    private float timer=0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
       
    }

    public void dragonshoot ()
    {
        GameObject municion = Instantiate(bala, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
        Rigidbody rigBala = municion.GetComponent<Rigidbody>();
        rigBala.AddForce(gameObject.transform.forward * 5000);
        timer = 3;
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (timer<0)
            {
                dragonshoot();
                timer = 3;
            }
           
        }
    }
}
