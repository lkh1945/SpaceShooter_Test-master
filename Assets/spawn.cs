using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public List<Transform> spawnArea;
    public GameObject spawnPrefab;
    public GameObject spawnBoss;
    GameManager gameManager;
    float interval = 0.5f;
    // Update is called once per frame
    private void Awake()
    {
        float rand = Random.Range(1f, 3f);
        Invoke("Spawn", rand);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    IEnumerator Start()
    {
        while (gameManager.enemyCount < 100)
        {
            int rand1 = Random.Range(0, 4);
            var pos = spawnArea[rand1].position;
            gameManager = Instantiate(spawnPrefab, pos);
            float rand = Random.Range(1f, 3f);
            yield return new WaitForSeconds(rand);
        }
    }
}
