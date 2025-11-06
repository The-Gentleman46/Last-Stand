using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        // Quits the application
        SceneManager.LoadScene("Main Menu");
    }
}
