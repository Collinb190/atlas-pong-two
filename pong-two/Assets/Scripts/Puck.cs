using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public float startSpeed = 600f;

    private Rigidbody2D rb;
    private Vector2 startingPoint;
    private Vector2 startingLaunch;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPoint = rb.position;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Launch()
    {
        float randomDirectionY = Random.Range(-1, 2);
        float randomDirectionX = Random.Range(0, 2) * 2 - 1;
        startingLaunch = new Vector2(randomDirectionX, randomDirectionY).normalized;
        rb.velocity = startingLaunch * startSpeed;
    }
}
