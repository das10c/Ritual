using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour {

    public AudioMixerSnapshot outOfCombat;
    public AudioMixerSnapshot inCombat;
    public float transitionInMsec = 500;
    public float transitionOutMsec = 2000;

    public bool isInCombat = false;
    private bool wasInCombat = false;
	
    void UpdateLate()
    {
        if (isInCombat && !wasInCombat)
        {
            inCombat.TransitionTo(transitionInMsec);
        }
        else if (!isInCombat && wasInCombat)
        {
            outOfCombat.TransitionTo(transitionOutMsec);
        }

        wasInCombat = isInCombat;
        isInCombat = false;
    }
}
