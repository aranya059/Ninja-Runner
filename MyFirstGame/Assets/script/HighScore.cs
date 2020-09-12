using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highScore;
    public void Start()
    {
        highScore.text = "High Score: "+PlayerPrefs.GetInt("highScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int number = ScoreScript.point;
        if(number>PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", number);
        }
        highScore.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString();
    }
    public void resetHighScore()
    {
        //PlayerPrefs.DeleteKey("highScore");
        //highScore.text = "High Score: " + "0";
        SceneManager.LoadScene(1);
        
    }
}
