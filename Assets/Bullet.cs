using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    Vector2 pos;
    private void Awake()
    {
        pos = transform.position;
    }
    private void Update()
    {
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
