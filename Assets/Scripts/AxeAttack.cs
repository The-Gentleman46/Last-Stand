using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        var zombie = other.gameObject.GetComponent<ZombieScript>();
        if (zombie != null)
        {
            zombie.life -= 1;
        }
    }
}
