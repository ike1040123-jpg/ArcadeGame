using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject target;
    private float distance;
    
    
 private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))


       
        SceneManager.LoadScene("DeathScreen");
    }
      
    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        
        
        transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);

        
        
    }
}
