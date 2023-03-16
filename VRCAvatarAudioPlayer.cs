using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCAvatarAudioPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource target;
    public int index;

    void OnEnable()
    {
        if (target)
        {
            target.Stop();
            AudioClip clip = getClip();
            if (clip)
            {
                target.PlayOneShot(clip);
            }
        }
    }

    private void OnDisable()
    {
        if (target)
        {
            target.Stop();
        }
    }

    private AudioClip getClip()
    {
        if (clips.Length > 0)
        {
            if (index < clips.Length)
            {
                return clips[index];
            }
        }
        return null;
    }
}
