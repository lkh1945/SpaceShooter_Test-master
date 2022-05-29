using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundWallScript : MonoBehaviour
{
    public float minX, minY, maxX, maxY;
    void Update()
    {
        // 최소, 최대 적용 적용.
        var pos = transform.position;

        if(pos.x < minX) pos.x = minX;
        if(pos.x > maxX) pos.x = maxX;
        if(pos.y < minY) pos.y = minY;
        if(pos.y > maxY) pos.y = maxY;
        transform.position = pos;
        Debug.Log(pos.x);
        Debug.Log(pos.y);
    }
}
