using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Update is called once per frame
    float speed;
    private void Awake()
    {
        speed = 10;
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.shootChance++;
    }
    void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
    
}
