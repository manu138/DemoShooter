using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPU : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            NotificationCenter.DefaultCenter().PostNotification(this, "ObtenerMunicion");
        }
   
    }
	
}
