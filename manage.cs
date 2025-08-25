using UnityEngine;
using UnityEngine.SceneManagement;//is added for restarting or loading new scene

public class manage : MonoBehaviour
{
    bool hasended = false;
    float delayrestart = 1f;
    public GameObject levelcomplete;
    
    public void EndGame()
    {
        if(hasended==false)
        {
            hasended = true;
            Debug.Log("game over");
            Invoke("restart", delayrestart); //in this we are using Invoke funtion instead of writing
                                             //function name simply because we want to have a liitle
                                             //delay while calling this function
        }
        
    }

    public void complete()
    {
        Debug.Log("game ended");
        levelcomplete.SetActive(true);


    }
      
    //this will restart the scene
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//SceneManager will be used
    }
   
}
