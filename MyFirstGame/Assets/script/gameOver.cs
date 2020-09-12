using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject End;
    void Start()
    {
        End.SetActive(false);
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Collector")
        {

            End.SetActive(true);
            Time.timeScale = 0f;
            //restartGame();
        }
    }*/
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "box"|| other.gameObject.tag == "Spike"|| other.gameObject.tag == "stone")
        {
            End.SetActive(true);
            Time.timeScale = 0f;
            //restartGame();
        }
    }
    public void restartGame()
    {
        ScoreScript.point = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
