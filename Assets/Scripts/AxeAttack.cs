using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public Kill_Counter killCounter;
    public void OnCollisionEnter2D(Collision2D other)
    {
        //zombie death linked to ZombieScript
        var zombie = other.gameObject.GetComponent<ZombieScript>();
        if (zombie != null)
        {
            killCounter.AddScore();
            zombie.life -= 1;
        }
    }
}
