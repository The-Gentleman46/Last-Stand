using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour
{
    public GameObject target; //the enemy's target
    public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning
    private Rigidbody2D rb;
    public float life = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //rotate to look at the player
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.forward - transform.forward), rotationSpeed * Time.deltaTime);
        //move towards the player
        var dir = (target.transform.position - rb.gameObject.transform.position).normalized;
        transform.position += dir * Time.deltaTime * moveSpeed;

        //Zombie Death
        if (life < 0)
        {
            Destroy(gameObject);
        }
    }

}