using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitScript : MonoBehaviour
{
    public float minY = -20;
    public float addY = 40;

    private void Update()
    {
        if (transform.position.y < minY)
        {
            transform.Translate(0, addY, 0);
        }
    }
}
