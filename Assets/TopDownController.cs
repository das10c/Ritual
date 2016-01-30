using UnityEngine;
using System.Collections;

public class TopDownController : MonoBehaviour {

    new Rigidbody rigidbody;
    bool first = true;
    public float speed = 10;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rigidbody.velocity = input * speed;
        if (input != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(input),
                Time.deltaTime * speed
            );
        }
    }
}
