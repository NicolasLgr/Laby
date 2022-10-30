using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;

    public Transform[] wayPoint;

    private Transform target;

    private int destPoint;

    public SpriteRenderer graphics;

    public int damageOnCollision = 20;

    // Start is called before the first frame update
    void Start()
    {
        target = wayPoint[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * (speed * Time.deltaTime), Space.World);

        //Si l'ennemi est quasiment arriv� � sa destination
        if(Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % wayPoint.Length;
            target = wayPoint[destPoint];
            graphics.flipX = !graphics.flipX;
        }
        
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnCollision);
        }
    }
}
