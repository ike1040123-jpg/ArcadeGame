using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
   public  GameObject Enemy;
   public  Transform Spawner;
   
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        StartCoroutine(SpawningFunction());
          yield return new WaitForSeconds(1);
    }

    
    IEnumerator SpawningFunction()
    {
        while (true)
        {
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          yield return new WaitForSeconds(1);
          
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          yield return new WaitForSeconds(1); 

          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          yield return new WaitForSeconds(1);
            
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          yield return new WaitForSeconds(1);
            
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          yield return new WaitForSeconds(1);
            
          Instantiate (Enemy, Spawner.position, Spawner.rotation);
          Instantiate (Enemy, Spawner.position, Spawner.rotation);

          yield return new WaitForSeconds(5);
          
        }
     }}
