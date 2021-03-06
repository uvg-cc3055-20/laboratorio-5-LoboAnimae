﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

	/*
	*@author Andres Quan Littow 17652
	*/ 
	
public class Character : MonoBehaviour
{
//This class manages the internal characteristics for the character

	//Declares new Rigid Body in 2D environment
    Rigidbody2D rb2d;
	
	//Renders animations
    SpriteRenderer sr;
	
	//Animates with the help of the SpriteRenderer
    Animator anim;
	
	//Sets the default character speed
    private float speed = 5f;
	
	//Sets the force with which the character can accelerate upwards
    private float jumpForce = 250f;
	
	//Checks if the character is facing right
    private bool facingRight = true;
	
	//Checks and helps manage the bottom part of the character
    public GameObject feet;
	
	//Helps with the layers
    public LayerMask layerMask;



	//Initialization of variables
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

	//Game updating mechanism
    void Update()
    {
		
		//Character movement
        float move = Input.GetAxis("Horizontal");
        if (move != 0)
        {
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }

        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;
		
		//checks for input and lets the character jump if there is anything under it
        if (Input.GetButtonDown("Jump"))
        {
            RaycastHit2D raycast =
            Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f,
            layerMask);
            if (raycast.collider != null)
            {
				//Adds force
                rb2d.AddForce(Vector2.up * jumpForce);
            }
        }
    }
}

