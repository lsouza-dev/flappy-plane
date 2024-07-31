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

    [SerializeField] private float yOffset;

    [SerializeField] private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        float posInicial = 16f;

        Vector2 randomPos = new Vector2(posInicial, Random.Range(-yOffset, yOffset));

        if (timer <= 0f)
        {
            var spawnedObject = Instantiate(obstaclePrefab, randomPos, Quaternion.identity);

            timerToSpawn = Random.Range(2, 4);
            timer = timerToSpawn;

        }
    }
}
