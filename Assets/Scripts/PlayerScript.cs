using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int health = 5;
    public GameObject[] hpSprites = new GameObject[6];
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        transform.position += movement * 5f * Time.deltaTime;
        for (int i = 0; i < hpSprites.Length; i++)
        {
            if (i == health)
            {
                hpSprites[i].SetActive(true);
            }
            else
            {
                hpSprites[i].SetActive(false);
            }
        }

        // Checks if the player is pressing left/right mouse and triggers attack animations
        bool Attack_Right = (Input.GetKeyDown(KeyCode.Mouse0));
        anim.SetBool("Attack_Right", Attack_Right);
        bool Attack_Left = (Input.GetKeyDown(KeyCode.Mouse1));
        anim.SetBool("Attack_Left", Attack_Left);
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("MedPack") == true)
        {
            healthChange(1);
            Destroy(coll.gameObject);

        }

    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy") == true)
        {
            healthChange(-1);        
        }
    }
    public void healthChange(int change)
    {
        if ((change < 0 && health > 0) || (change > 0 && health < 5))
        {
            health += change;
        }
    }
}