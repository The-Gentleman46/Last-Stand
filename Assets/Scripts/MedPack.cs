using UnityEngine;

public class MedPack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void OnCollisionEnter2D (Collision2D coll)
    {
        coll.gameObject.GetComponent<PlayerScript>().healthChange(1);
    }
}
