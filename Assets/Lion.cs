using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : MonoBehaviour
{

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        print("Player distance: " + distToPlayer);

        if(distToPlayer < agroRange)
        {
            //Mf gonna die
            ChasePlayer();
            Debug.Log("Chasing Player");
        }
        else
        {
            StopRunning();
        }

        void ChasePlayer()
        {
            if(transform.position.x < transform.position.x)
            {
                rb2d.velocity = new Vector2(moveSpeed, 0);
                Debug.Log("Chasing player left");
            }
            else if (transform.position.x > transform.position.x)
            {
                rb2d.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("Chasing player right");
            }
        }

        void StopRunning()
        {
            rb2d.velocity = new Vector2(0, 0);
        }
        
    }
}
