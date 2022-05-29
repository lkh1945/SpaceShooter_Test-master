using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Vector3 pos;
    public float speed, minX, maxX, minY, maxY;
    public GameObject missile, effect;
    private void Awake()
    {
        pos = transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) pos.y += speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) pos.y -= speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow)) pos.x -= speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow)) pos.x += speed * Time.deltaTime;

        if(pos.x < minX) pos.x = minX;
        if(pos.x > maxX) pos.x = maxX;
        if(pos.y < minY) pos.y = minY;
        if(pos.y > maxY) pos.y = maxY;
        
        if(Input.GetKeyDown(KeyCode.Alpha1)) FindObjectOfType<scoreText>().AddScore(100);
        transform.position = pos;
    }
    private void OnDestroyEffect()
    {
        var effectDes = Instantiate(effect);
        effectDes.transform.position = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            OnDestroyEffect();
            Destroy(gameObject);
        }
    }
}
