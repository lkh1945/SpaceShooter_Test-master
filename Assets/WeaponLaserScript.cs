using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLaserScript : MonoBehaviour
{
    public GameObject missile;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newMissile = Instantiate(missile);
            newMissile.transform.position = transform.position;
        }
    }
    public void FireLazer()
    {
        var newMissile = Instantiate(missile);
        newMissile.transform.position = transform.position;
    }
}
