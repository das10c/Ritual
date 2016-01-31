using UnityEngine;
using System.Collections;

public class TopDownController : MonoBehaviour {

    new Rigidbody rigidbody;
    public float speed = 10;
    public GameObject cone;
    bool hasRock = false;
    float rockStrength = 20;

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
            transform.GetChild(0).rotation = Quaternion.Slerp(
                transform.GetChild(0).rotation,
                Quaternion.LookRotation(input),
                Time.deltaTime * speed
            );
        }
        if (Input.GetButton("Fire1"))
        {
            cone.SetActive(true);
        }
        else
        {
            cone.SetActive(false);
        }
        RaycastHit hit;
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.DrawRay(transform.position, Vector3.down, Color.white,  10.0f, false);
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                print(hit.collider.gameObject);
                if (!hasRock && hit.collider.tag == "Rock")
                {

                    hasRock = true;
                    //TODO: Dive Animation
                    //TODO: Dust Particles
                    GameObject.Destroy((hit.collider.gameObject));
                }

                else if (hasRock)
                {
                    hasRock = false;
                    //TODO: Shatter Particles
                    GroundEnemyAI enemy = hit.collider.gameObject.GetComponent<GroundEnemyAI>();
                    if (enemy != null)
                    { 
                        enemy.health -= rockStrength;
                        print(enemy.health);
                    }

                }
            }
        }
    }
}
