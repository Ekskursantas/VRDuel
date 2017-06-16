using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{


    public AudioClip hitmesh;
    public AudioSource source;



    void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.gameObject.tag == "sword")
        {
            source = GetComponent<AudioSource>();
            source.PlayOneShot(hitmesh);

        }

    }

}
