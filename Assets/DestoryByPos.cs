using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByPos : MonoBehaviour
{
    public float maxY = 10;
    public float minY = -10;
    private void Update()
    {
        float y = transform.position.y;
        if (y > maxY) Destroy(gameObject);
        else if(y < minY) Destroy(gameObject);
    }
}
