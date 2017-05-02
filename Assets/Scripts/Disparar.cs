using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour
{

    public GameObject bala;
    public int puntos = 0;
    public int municion = 10;



    // Use this for initialization
    void Start()
    {

        NotificationCenter.DefaultCenter().AddObserver(this, "Puntuar");
        NotificationCenter.DefaultCenter().AddObserver(this, "ObtenerMunicion");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (municion == 0)
            {
                Debug.Log("no hay balas");
            }
            else
            {
                GameObject clonBala = Instantiate(bala, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
                clonBala.GetComponent<Rigidbody>().AddForce(clonBala.transform.forward * 50, ForceMode.VelocityChange);
                municion = municion - 1;
            }
        }

    }

    void Puntuar(Notification notificacion)
    {

        puntos += 100;

    }

    void ObtenerMunicion()
    {

        municion += 5;

    }
}
