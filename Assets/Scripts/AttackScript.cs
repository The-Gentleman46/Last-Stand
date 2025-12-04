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
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            Axe_Hitbox.SetActive(true);
            anim.SetTrigger("Attack_Right");
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Axe_Hitbox.SetActive(true);
            anim.SetTrigger("Attack_Left");
        }
    }
  
}
