using UnityEngine;
using System.Collections;

public class LightningEffect : MonoBehaviour {

    public float strength = 50;

    void OnTriggerEnter(Collider other)
    {
        print("here");
        AirEnemyAI enemy = other.GetComponent<AirEnemyAI>();
        if (enemy != null)
        {
            enemy.health -= strength;
        }
    }
}
