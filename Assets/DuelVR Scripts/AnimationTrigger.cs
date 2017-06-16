using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{



    public void OnTriggerEnter(Collider otherv2)
    {
        

        if (otherv2.gameObject.tag == "sword")
        {
           
            GetComponent<Animation>().Play("Hit");


        }

    }
 
}
