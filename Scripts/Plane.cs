using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float restartTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlaneUp();
        MoveTest(); 
    }

    private void PlaneUp()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
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

    private void MoveTest()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {

        }
        else if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.eulerAngles += new Vector3(0, 0, rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.eulerAngles += new Vector3(0, 0, -rotationSpeed);
        }
    }
}
