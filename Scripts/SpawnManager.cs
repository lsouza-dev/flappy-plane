using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Principal;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    [SerializeField] private float timer = 1f;
    [SerializeField] private float timerToSpawn = 1f;
    [SerializeField] private float timeToDestroy;

    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

    [SerializeField] private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        Vector2 randomPos = new Vector2(pos.x, Random.Range(yMin, yMax));

        if (timer <= 0f)
        {
            GameObject obstacleInstance = Instantiate(obstaclePrefab, randomPos, Quaternion.identity);
            Destroy(obstacleInstance,timeToDestroy);
            timerToSpawn = Random.Range(2, 4);
            timer = timerToSpawn;

        }
    }
}
