using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int health = 5;
    public bool immune = false;
    public GameObject[] hpSprites = new GameObject[6];
    public Animator anim;
    public GameObject Axe_Hitbox;
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

        

    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (!immune && coll.gameObject.CompareTag("MedPack") == true)
        {
            healthChange(1);
            Destroy(coll.gameObject);
        }

        
    }

    public void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy") == true)
        {
            if (!immune)
            {
                healthChange(-1);
                StartCoroutine(DoImmunity(2));
            }
        }
    }
    IEnumerator DoImmunity(float immuneTime) {
        immune = true;
        float timer = 0;
        while( timer < immuneTime )
        {
            yield return null;
            timer += Time.deltaTime;
        }
        immune = false;
    }
    public void healthChange(int change)
    {
        if ((change < 0 && health > 0) || (change > 0 && health < 5))
        {
            health += change;
        }
    }
}