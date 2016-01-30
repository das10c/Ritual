using UnityEngine;
using System.Collections;

public class arrowturret : MonoBehaviour {
    public Rigidbody arrowbolts;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 100; i++)
        {
            var arrow = Instantiate(arrowbolts);
        }
    }
}
