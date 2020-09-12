using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUp_QuitGame : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject exitPanel;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene().buildIndex!=0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if(exitPanel)
                {
                    exitPanel.SetActive(true);
                }
            }
        }
    }
    public void OnUserClickYesNo(int choise)
    {
        if(choise==1)
        {
            Application.Quit();
        }
        exitPanel.SetActive(false);
    }
    public void onUserClickStart()
    {
        //SceneManager.LoadScene(1);
        exitPanel.SetActive(true);
    }
}
