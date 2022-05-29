using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public List<Transform> spawnArea;
    public GameObject spawnPrefab;
    float interval = 0.5f;
    // Update is called once per frame
    private void Awake()
    {
        float rand = Random.Range(1f, 3f);
        Invoke("Spawn", rand);
    }

    private void Spawn()
    {
        var spawn = Instantiate(spawnPrefab);
        spawn.transform.position = transform.position;
        float rand = Random.Range(1f, 3f);
        Invoke("Spawn", rand);
    }

    IEnumerator start()
    {
        while (true)
        {

            float rand = Random.Range(0, interval);
            yield return new WaitForSeconds(rand);
        }
    }
}
