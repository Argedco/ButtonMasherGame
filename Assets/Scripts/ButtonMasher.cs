using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Button Clicking Sound
    public TextMesh scoreText; //Display text for the player's score

    private int score = 0; //Declares the numeral score

	// Use this for initialization
	void Start () {
        Debug.Log("Start Method Called.");

	} // End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update Method Triggered.");
	} // End of Update()

    //Responds to to even from Unity, that the object has been clicked.
    private void OnMouseDown() {
        Debug.Log("The mouse has clicked on the object. OnMouseDown triggered.");
        clickSound.Play();
        //increase the score by 1
        score = score + 1;
        //update visual score
        scoreText.text = score.ToString();
    } // End of OnMouseDown.
} // End of ButtonMasher Class
