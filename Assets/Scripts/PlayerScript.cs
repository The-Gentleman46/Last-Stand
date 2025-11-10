using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    int health = 5;
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

    public void healthChange(int change)
    {
        health += change;
    }
}
