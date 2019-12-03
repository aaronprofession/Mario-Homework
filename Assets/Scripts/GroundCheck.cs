using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject Player;
    //Grabs Player Parent Gameobject
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }
    //isGrounded
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" || collision.tag == "MysteryBox")
        {
            Player.GetComponent<PlayerController>().isGrounded = true;
            Debug.Log("Player Grounded.");
        }
    }
    //notGrounded
    private void OnTriggerExit2D(Collider2D collision)

    {
        if (collision.tag == "Ground" || collision.tag == "MysteryBox")
        {
            Player.GetComponent<PlayerController>().isGrounded = false;
            Debug.Log("Player in Air.");
        }
    }

}
