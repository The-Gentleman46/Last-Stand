using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Animator anim;
    public GameObject Axe_Hitbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if the player is pressing Q/E and triggers attack animations
        Axe_Hitbox.SetActive(false);
        if (Input.GetKeyDown("e"))
        {
            Axe_Hitbox.SetActive(true);
            anim.SetTrigger("Attack_Right");

        }
        else if (Input.GetKeyDown("q"))
        {
            Axe_Hitbox.SetActive(true);
            anim.SetTrigger("Attack_Left");
        }
        else
        {
            Axe_Hitbox.SetActive(false);
        }
    }
}
