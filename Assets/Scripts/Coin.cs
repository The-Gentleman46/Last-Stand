using UnityEngine;

public class Coin : MonoBehaviour
{
    // Cashe the refrence to the Platform Manager
    private PlatformManager _manager;

    private void Start()
    {
        // find the object that contains the script platform manager and cache it into a variable
        _manager = GameObject.FindObjectOfType<PlatformManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _manager.CollectCoin();

        Destroy(this.gameObject);
    }
}
