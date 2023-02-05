using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveProjectile : MonoBehaviour
{
    private Rigidbody2D projectile;
    public float moveSpeed = 5.0f; //slowing speed of enemy bullet

    // Start is called before the first frame update
    void Start()
    {
        projectile=this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity=new Vector2(0,-1) * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //collide with enemy -hide/destroy enemy
        if(collision.gameObject.tag == "Player")
       {
            collision.gameObject.SetActive(false);
       }
      //bullets hit the bottom wall ->destroy
       if(collision.gameObject.name == "downWall ")
       {
              Destroy(this.gameObject);
        }
    
     }
}
