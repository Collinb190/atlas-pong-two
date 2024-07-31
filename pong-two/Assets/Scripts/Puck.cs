using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public float startSpeed = 600f;

    private Rigidbody2D rb;
    private Vector2 startingPoint;
    private Vector2 startingLaunch;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startingPoint = rb.position;
        Launch();
    }

    void Launch()
    {
        float randomDirectionY = Random.Range(-1, 2);
        float randomDirectionX = Random.Range(0, 2) * 2 - 1;
        startingLaunch = new Vector2(randomDirectionX, randomDirectionY).normalized;
        rb.AddForce(startingLaunch * this.startSpeed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
}
