using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float impulse;

    public Transform skin;
    public GameOver gameOver;

    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump();

        }
    }

    public void jump()
    {
        rigid.AddForce(new Vector2(0f, impulse), ForceMode2D.Impulse);

    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        gameOver.gameOverAction();
    }


}
