using UnityEngine;
using System.Collections;

public class EndTarget : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            MySceneManager.EndGame();
        }
    }
}
