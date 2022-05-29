using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    // 키버튼을 이용해서 움직이자.
    Vector3 pos;
    public float speed;
    public float minX, maxX, minY, maxY;
    private void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        pos.x += speed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        pos.y += speed * Input.GetAxisRaw("Vertical") * Time.deltaTime;

        if(pos.x < minX) pos.x = minX;
        if(pos.x > maxX) pos.x = maxX;
        if(pos.y < minY) pos.y = minY;
        if(pos.y > maxY) pos.y = maxY;
        transform.position = pos;
        //pos = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        //transform.position = pos;  
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall")
        {
            print("Wall");
        }
    }
}
