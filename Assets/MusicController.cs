using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour {

    public AudioMixerSnapshot outOfCombat;
    public AudioMixerSnapshot inCombat;
    public float transitionInMsec = 500;
    public float transitionOutMsec = 2000;
	
    public void combatTransitionIn()
    {
        inCombat.TransitionTo(transitionInMsec);
    }

    public void combatTransitionOut()
    {
        inCombat.TransitionTo(transitionOutMsec);
    }
}
