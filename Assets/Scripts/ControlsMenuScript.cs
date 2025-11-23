using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenuScript : MonoBehaviour
{
    public void instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
