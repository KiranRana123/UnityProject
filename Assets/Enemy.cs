using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemy;
    public float moveSpeed=10.0f;
    private bool changeDirection = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }
    void moveEnemy()
    {
        if(changeDirection == true)
         enemy.velocity = new Vector2(1,0) * -1 *moveSpeed;
        else
         enemy.velocity = new Vector2(1,0)*moveSpeed;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RightWall")
        {
            changeDirection = true;
        }
          if(collision.gameObject.name == "LeftWall ")
        {
            changeDirection = false;
        }
    }
}
