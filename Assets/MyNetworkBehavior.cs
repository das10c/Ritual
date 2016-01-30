using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkBehavior : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	    if (isLocalPlayer)
        {
            TopDownController tdc = GetComponent<TopDownController>();
            if (tdc != null)
            {
                tdc.enabled = true;
            }
            UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController rbfpc = GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>();
            if(rbfpc != null)
            {
                rbfpc.enabled = true;
            }
            GameObject camera = GameObject.Find("Scene Camera");
            if (camera != null)
            {
                camera.SetActive(false);
            }
            GetComponentInChildren<Camera>().enabled = true;
            GetComponentInChildren<AudioListener>().enabled = true;
        }
	}
}
