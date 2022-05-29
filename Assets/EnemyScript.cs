using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject effect;
    public GameObject gameManager;
    public float speed;

    public int hp;
    private void Awake()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.enemyCount++;
    }
    private void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
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
            hp -= collision.GetComponent<BulletScript>().power;
            if(hp <= 0)
            {
                OnDestroyEffect();
                Destroy(gameObject);
            }
        }
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag("Wall")) Destroy(gameObject);
    }
}
