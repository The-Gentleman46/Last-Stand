using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    int coins = 0;

    public void CollectCoin()
    {
        coins++;
    }

    public int GetCoins()
    {
        return coins;
    }
}
