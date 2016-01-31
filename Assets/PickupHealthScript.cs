using UnityEngine;
using System.Collections;

public class PickupHealthScript : MonoBehaviour {

    GameObject player = null;
    health h;

    public float rotationRate = 50;
    public float recoveryAmount = 25;

	// Use this for initialization
	void Start ()
    {
        h = FindObjectOfType<health>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3 (0, rotationRate, 0) * Time.deltaTime);

	    if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Ground");
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            h.updateHealth(recoveryAmount);
        }
    }
}
