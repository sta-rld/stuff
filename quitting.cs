using UnityEngine;

public class quitting : MonoBehaviour
{
  public void quit ()
    {
        Application.Quit ();
        Debug.Log("quit");
    }
}
