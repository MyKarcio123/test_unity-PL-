﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocisk : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;
    movement target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<movement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
}
