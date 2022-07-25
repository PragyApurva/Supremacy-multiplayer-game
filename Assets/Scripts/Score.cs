using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Score : MonoBehaviour 
{
 
    public Text scoreTextBlue;
    public Text scoreTextRed;
    public Text timerText;
    public int scoreBlue;
    public int scoreRed;
    public float timer=60f;
    
 
    void Start() 
    {
        //if( collider is blue player)
            scoreTextBlue.text = "Blue :  " + scoreBlue; // To make sure the score text is accurate
            
        //if( collider is Red player)
             scoreTextBlue.text = "Red :  " + scoreRed; // To make sure the score text is accurate
             timerText.text="Time : " + timer +" s";
    }
    void Update()
    {
        timer-=Time.deltaTime;
        timerText.text="Time : " + (int)timer +" s";
        // if(time==0) { // We only need to check if the score is high enough when it increases, not every frame.
        //     SceneManager.LoadScene("end menu");
        // }
    }
 
    public void IncreaseScore() 
    {
        // Increase score accoding who collided we can mannage in pickup script
        scoreBlue++;
            scoreTextBlue.text = "Blue :  " + scoreBlue;
        scoreRed++;
            scoreTextRed.text = "Red :  " + scoreRed;
        
        // if(score >= 6) { // We only need to check if the score is high enough when it increases, not every frame.
        //     SceneManager.LoadScene("end menu");
        // }
    }
}