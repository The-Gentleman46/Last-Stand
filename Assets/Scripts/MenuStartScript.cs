using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStartScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("FightLevel");
    }
}

