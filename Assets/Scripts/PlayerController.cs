using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public float jumpheight = 2f;
    public float longJumpheight = 4f;
    public float speed;
    public bool isGrounded = false;
    public Animator animator;
    private float runDirect;
    private AudioSource playerSound;
    // Private variables
    private Rigidbody2D rBody;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        playerSound = GetComponent<AudioSource>();
    }
    //Flips character sprite upon direction change
    private void Update()
    {
        Vector3 characterFlip = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterFlip.x = -1;
            runDirect = -1;
            Debug.Log("Character is Flipped Left");
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterFlip.x = 1;
            runDirect = 1;
            Debug.Log("Character is Flipped Right");
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            runDirect = 0;
        }
        transform.localScale = characterFlip;
        animator.SetBool("isGrounded", isGrounded);
    }
    //Horizantal Movement
    void FixedUpdate()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), 0f);
        //Debug.Log(movement);
        animator.SetFloat("Speed", runDirect);
        Debug.Log(runDirect);
        JumpCheck();
        rBody.position += movement * Time.deltaTime * speed;
    }
    //Jump Movement
    void JumpCheck()
    {
        if(Input.GetKeyDown(KeyCode.W) && isGrounded == true || Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            playerSound.Play();
            rBody.AddForce(new Vector2(0f, longJumpheight), ForceMode2D.Impulse);
            Debug.Log("Player has Long Jumped");
            
        }
        else if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            rBody.AddForce(new Vector2(0f, jumpheight), ForceMode2D.Impulse);
            Debug.Log("Player has Short Jumped");
        }
        
    }
}
