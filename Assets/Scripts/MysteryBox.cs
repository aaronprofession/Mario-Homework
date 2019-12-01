using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    private Animator anim;
    
    
    
    private void Start()
    {
        anim = GetComponent<Animator>();
       
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "Player")
        {
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
        else
        {
            anim.SetBool("bashed", true);
           
           
        } 
    }
   
}
