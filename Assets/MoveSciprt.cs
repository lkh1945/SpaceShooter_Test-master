using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSciprt : MonoBehaviour
{
    public float speed;
    void Update()
    {
        // 밑으로 움직이게 하고 싶다.
        // transform의 y값을 점점 빼고 싶다.
        Vector3 pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
    }
}
