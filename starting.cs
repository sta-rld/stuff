using UnityEngine;
using UnityEngine.SceneManagement;

public class starting : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("game start");
    }
}
