using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int health = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        transform.position += movement * 5f * Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("MedPack") == true)
        {
            healthPickup(1);
            Destroy(coll.gameObject);

        }

    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy") == true)
        {
            healthPickup(-1);        
        }
    }

    public void healthPickup(int change)
    {
        health += change;
    }
}
