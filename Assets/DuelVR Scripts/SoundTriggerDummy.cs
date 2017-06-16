using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggerDummy : MonoBehaviour {

    public AudioClip hitSound;
    private AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "sword")
        {
            source = GetComponent<AudioSource>();
            source.PlayOneShot(hitSound);
        }
    }
}
