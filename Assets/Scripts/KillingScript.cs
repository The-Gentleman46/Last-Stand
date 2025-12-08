using UnityEngine;
public class KillingScript : MonoBehaviour
{
    public Kill_Counter killCounter;
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
           Destroy(coll.gameObject);
           killCounter.AddScore();
        }
    }
}