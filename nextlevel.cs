using UnityEngine;
using UnityEngine.SceneManagement;
public class nextlevel : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
