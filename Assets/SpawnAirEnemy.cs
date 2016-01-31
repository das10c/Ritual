using UnityEngine;
using System.Collections;

public class SpawnAirEnemy : MonoBehaviour {

    public int timer = 0;
    float passedTime = 0;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        passedTime += Time.deltaTime;
	    if (timer < passedTime)
        {
            passedTime = 0;
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
	}
}
