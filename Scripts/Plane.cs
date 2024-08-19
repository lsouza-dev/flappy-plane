using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float restartTime;
    [SerializeField] private GameObject smoke;
    [SerializeField] private GameObject smokePrefab;


    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlaneUp();
    }

    private void PlaneUp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
            CreateSmoke();
        }
    }

    private void LimitSpeed()
    {
        rb.velocity = new Vector2(rb.velocity.x, -speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        RestartGame();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    private void CreateSmoke()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        smoke = Instantiate(smokePrefab, pos, Quaternion.identity);

        Destroy(smoke,2f);
    }
}
