﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Button Clicking Sound
    public TextMesh scoreText; //Display text for the player's score
    public TextMesh timerText; //Display text for the timer
    public float gameLength; // how many seconds will the game last

    private int score = 0; //Declares the numeral score
    private float timeRemaining = 0; //Numerical data for remaining time
    private bool gameRunning = true;

    // Use this for initialization
    void Start () {
        Debug.Log("Start Method Called.");

        timeRemaining = gameLength; 
	} // End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update Method Triggered.");

        timeRemaining = timeRemaining - Time.deltaTime;
        // Numerical data update

        //update the visual time remaining
        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        // Consistently check if the time has run out
        if (timeRemaining <= 0)
        {
            gameRunning = false;

            //stop our time from going negative
            timeRemaining = 0;
        }//end of if time running

	} // End of Update()

    //Responds to to even from Unity, that the object has been clicked.
    private void OnMouseDown() {
        Debug.Log("The mouse has clicked on the object. OnMouseDown triggered.");

        //checks to see if game is still running
        if (gameRunning == true)
        {
            clickSound.Play();
            //increase the score by 1
            score = score + 1;
            //update visual score
            scoreText.text = score.ToString();
        } //ends if statement.
    } // End of OnMouseDown.
} // End of ButtonMasher Class
