using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector2 traget;
    public float speed;
    void Start()
    {
        traget = Camera.main.ScreenToWorldPoint(Input.mousePosition);    
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, traget, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,traget)==0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
