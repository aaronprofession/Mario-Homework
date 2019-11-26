using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveTrack : MonoBehaviour
{   //Allows mario to push the camrea when he is moving in the middle of the screen.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
            camBody.isKinematic = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody2D camBody = GetComponentInParent<Rigidbody2D>();
            camBody.isKinematic = true;
        }
    }
}
