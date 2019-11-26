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
    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if(other.gameObject.tag == "Player")
    //    {
    //        Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
    //        camBody.isKinematic = false;
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
    //        camBody.isKinematic = true;
    //    }
    //}
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        float step = speed * Time.deltaTime;
        Rigidbody2D pb = thePlayer.GetComponent<Rigidbody2D>();
        
        Vector2 playV = pb.position;
        playV.y = camBody.position.y;
        Vector2 camV = new Vector2(camBody.position.x, camBody.position.y);
        Vector2.MoveTowards(transform.position, pb.position, step);
    }
}
