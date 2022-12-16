using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantAI : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D ElephantRig;
    BoxCollider2D ElephantCollider;
    // Start is called before the first frame update
    void Start()
    {
        //Empty 
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            ElephantRig.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            ElephantRig.velocity = new Vector2(-moveSpeed, 0f);
        }
        
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(ElephantRig.velocity.x)), transform.localScale.y);
    }
}
