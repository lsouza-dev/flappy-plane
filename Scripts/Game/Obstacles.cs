using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] public float speed;
    private Rigidbody2D rb;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DefaultMove();
    }

    private void DefaultMove()
    {
        rb.velocity = new Vector2(-speed - gameManager.ReturnLevel(), 0);
    }
}
