using UnityEngine;
using TMPro;
public class KillCounter : MonoBehaviour
{
    
   public int ScoreValue = 0;
   public TMP_Text score;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null)
        {
    
       
        score.text = "Score: " + ScoreValue.ToString();
       
        }
         
    }
}
