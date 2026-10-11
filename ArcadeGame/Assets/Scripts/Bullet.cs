using UnityEngine;

public class Bullet : MonoBehaviour
{
    public KillCounter KillCounter;
    public float speed = 20f;
    public Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.right * speed;
        KillCounter = Object.FindAnyObjectByType<KillCounter>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Debug.Log("Bullet hit something");
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null )
        {
            enemy.TakeDamage(100);
            KillCounter.ScoreValue += 1;
            Debug.Log("Found Enemy Collider");
        }
        
        Destroy(gameObject);
       
    }
}