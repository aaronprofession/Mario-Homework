using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrack : MonoBehaviour
{
    
   
    private void OnCollisionEnter2D(Collision2D other)
    {   //Stops enemies and other objects from being moved by camerea collider
        if (other.gameObject.tag != "Player")
        {
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
    }
    
    
}
