using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flylogi : MonoBehaviour
{
    public float flyForce;
    private Rigidbody2D rb2d;
    public GameOver game;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FLY();
    }

    void FLY()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * flyForce;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        game.GameOverActive();

    }
}
