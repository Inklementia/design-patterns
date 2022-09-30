using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayerBehaviour : MonoBehaviour
{
    private static AmbientAudioPlayerBehaviour instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    
    }
 
    private AmbientAudioPlayerBehaviour()
    {

    }
    public void FadeNewMusic()
    {

    }
}
