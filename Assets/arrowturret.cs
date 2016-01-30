using UnityEngine;
using System.Collections;

public class arrowturret : MonoBehaviour {
    public GameObject arrowbolt;

	// Update is called once per frame
	void Update () {
        //if(Input.GetButtonDown("Fire1"))
        //{
        GameObject arrow = Instantiate(arrowbolt, transform.position, Quaternion.identity) as GameObject;
        arrow.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f);
        // }
    }
}
