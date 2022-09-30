using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayer : MonoBehaviour
{
    private static AmbientAudioPlayer instance;
    public static AmbientAudioPlayer GetIt()
    {
        if (instance == null)
        {
            instance = new AmbientAudioPlayer();
        }
        return instance;

        //if(instance == null)
        //{
        //    instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}
    }
    private AmbientAudioPlayer()
    {

    }
    public void FadeNewMusic()
    {

    }
}
