using UnityEngine;
using System.Collections;

public class GroundActions : MonoBehaviour {

    public float meleeStrength = 35;
    public float meleeRange = 3;
    public GameObject marker;
    float doubleClickStart = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            //TODO: Sword swing animation
            //TODO: Sound effects
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, meleeRange))
            {
                GroundEnemyAI enemy = hit.collider.gameObject.GetComponent<GroundEnemyAI>();
                if (enemy != null)
                {
                    enemy.health -= meleeStrength;
                }
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                GroundEnemyAI enemy = hit.collider.gameObject.GetComponent<GroundEnemyAI>();
                if (enemy != null && enemy.GetComponentInChildren<AudioSource>() == null)
                {
                    GameObject m = Instantiate(marker, enemy.transform.position, Quaternion.identity) as GameObject;
                    m.transform.parent = enemy.transform;
                }
            }
        }
    }
}
