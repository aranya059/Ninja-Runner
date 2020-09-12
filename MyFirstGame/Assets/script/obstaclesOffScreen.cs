using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstaclesOffScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collector")
        {
            gameObject.SetActive(false);
        }
        else if(other.tag == "PointCollector")
        {
            ScoreScript.point++;
        }
    }
   
}
