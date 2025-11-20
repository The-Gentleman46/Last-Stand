using UnityEngine;


public class KillingScript : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
           Destroy(coll.gameObject);
           
        }
    }
    /*public void AddScore(int score)
        {
            playerScore += score;
        }*/
}

