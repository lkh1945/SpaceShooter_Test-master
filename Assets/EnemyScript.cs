using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject effect;
    public GameObject gameManager;
    private void Update()
    {
        transform.Translate(0, -0.01f, 0);
    }
    private void OnDestroyEffect()
    {
        var explos = Instantiate(effect);
        explos.transform.position = transform.position;
    }
    void plusScore()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.score++;
    }
    void hit()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.hit++;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Bullet"))
        {
            FindObjectOfType<scoreText>().AddScore(100);
            hit();
            plusScore();
            Destroy(collision.gameObject);
            OnDestroyEffect();
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag("Wall")) Destroy(gameObject);
    }
}
