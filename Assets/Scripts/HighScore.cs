using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // NEEDED FOR uGUI TO WORK

public class HighScore : MonoBehaviour
{   static public int   score = 1000;

    void Awake() {
        // if the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("High Score")){
            score = PlayerPrefs.GetInt("High Score");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("High Score", score);
    }

    // Update is called once per frame
    void Update()
    {   Text gt = this.GetComponent<Text>();
        gt.text = "High Score: "+score;
        // Update the PlayerPrefs HighScore if necessary
        if (score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("High Score", score);
        }
        
    }
}
