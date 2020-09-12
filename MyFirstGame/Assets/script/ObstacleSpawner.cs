using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] obstacles;
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();
    int index;
    private void Awake()
    {
        InitiObstacle();
    }
    void Start()
    {
        StartCoroutine(SpawnRandomObstacle());
    }


    void InitiObstacle()
    {
        index = 0;
        for (int i = 0; i < obstacles.Length*3; i++)
        {
            GameObject obj = Instantiate(obstacles[index], transform.position, Quaternion.identity);
            obstaclesToSpawn.Add(obj);
            obstaclesToSpawn[i].SetActive(false);
            index++;
            if (index == obstacles.Length)
            {
                index = 0;
            }
        }
    }
    IEnumerator SpawnRandomObstacle()
    {
        
        yield return new WaitForSeconds(Random.Range(3f, 6f));
        int index = Random.Range(0, obstaclesToSpawn.Count);
        while (true)
        {
            if (!obstaclesToSpawn[index].activeInHierarchy)
            {
                obstaclesToSpawn[index].SetActive(true);
                obstaclesToSpawn[index].transform.position = transform.position;
                break;
            }
            else
            {
                index = Random.Range(0, obstaclesToSpawn.Count);
            }
        }
        StartCoroutine(SpawnRandomObstacle());
    }
}

