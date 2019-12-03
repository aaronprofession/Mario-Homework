using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rbody;
   
    
    public  Transform target, returnTarget;


    int count = 0;
    public bool moveTowards, moveAway = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        target = posA;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player has collided");
            anim.SetBool("bashed", true);

            moving = true;
        }

    }
    public Transform posA;
    public Transform posB;
    public float speed = 1;

    bool A = true;
    bool moving = false;
    void Update()
    {
        
        
        //Switches Target everytime a Target is Reached
        if (transform.position == target.position && count != 2)
        {
            count++;
            if (A == true)
            { A = false; }
            else if (A == false)
            { A = true; }
        }
        if (A == true && moving)
        { target = posA; }
        else if (A == false)
        { target = posB; }

        if( count == 2)
        {
           Destroy(GetComponent<EdgeCollider2D>());
        }
    }
    
    //Moves Object towards current Target
    private void FixedUpdate()
    {
        if (count != 2 && moving == true)
        {
            float step = speed * Time.deltaTime;
            rbody.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
        
    }






    //private void FixedUpdate()
    //{
    //    float step = returnSpeed * Time.deltaTime;

    //    if (moveAway == true && transform.position != target.position)
    //    { 
    //        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    //    }
    //    if(transform.position == target.position)
    //    {
    //        moveAway = false;
    //        if(transform.position == returnTarget.position)
    //        {
    //            Destroy(GetComponent<MysteryBox>());
    //        }
    //        else
    //        {
    //            transform.position = Vector2.MoveTowards(transform.position, returnTarget.position, step);
    //        }
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D other)
    //{




    //}


}
