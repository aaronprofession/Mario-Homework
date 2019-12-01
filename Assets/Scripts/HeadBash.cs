using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBash : MonoBehaviour
{
    public AudioClip[] aclips;
    private AudioSource audio;
    public GameObject brickAnim;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Brick")
        {
            audio.clip = aclips[0];
            audio.Play();
            Instantiate(brickAnim);
        }
       
        if (other.tag != "MainCamera" && other.tag != "MysteryBox")
        {
            Destroy(other.gameObject);
        }

    }
   
}
