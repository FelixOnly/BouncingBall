using UnityEngine;


//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 

public class DangerosZone : MonoBehaviour
{
    /* This is a die zone where player will die */
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Checking object that we found 
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerMoving>().Die();
        }
    }
}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 
