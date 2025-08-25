using UnityEngine;

public class endlevel : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindAnyObjectByType<manage>().complete();
    }

}
