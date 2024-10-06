using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;

    public float paddleSpeed = 9f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
