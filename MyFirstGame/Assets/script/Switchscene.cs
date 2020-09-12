using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame(string scene)
    {
        SceneManager.LoadScene(scene);

    }
}
