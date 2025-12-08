using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        //zombie death linked to ZombieScript
        var zombie = other.gameObject.GetComponent<ZombieScript>();
        if (zombie != null)
        {
            zombie.life -= 1;
        }
    }
}
