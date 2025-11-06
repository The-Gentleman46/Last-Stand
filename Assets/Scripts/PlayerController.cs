using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.linearVelocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector3(3f, vel.y, vel.z);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector3(-3f, vel.y, vel.z);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 5f, rb.linearVelocity.z);

        }
 
    }
}
