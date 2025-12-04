using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMainMenuScript : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}