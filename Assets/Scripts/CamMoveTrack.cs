using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveTrack : MonoBehaviour
{   //Allows mario to push the camrea when he is moving in the middle of the screen.
    PlayerController playerscript;
    Rigidbody2D camBody;
    GameObject thePlayer;
    private float speed = 10.0f;
    private void Start()
    {
        thePlayer = GameObject.Find("Player");
        PlayerController playerscript = thePlayer.GetComponent<PlayerController>();

        camBody = GetComponentInParent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
            camBody.isKinematic = false;
        }
        else
        {
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
            camBody.isKinematic = true;
            camBody.velocity = new Vector2(0,0);
        }
    }



}
