using UnityEngine;
using System.Collections;

public class AirEnemyAI : MonoBehaviour
{
    GameObject player = null;
    Transform playerT = null;
    float MoveSpeed = 4;
    float MaxDist = 10;
    float MinDist = 5;

    void Update()
    {
        Chase();
    }

    void Chase()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Flying");
        }
        else if(playerT == null)
        {
            playerT = player.transform;
        }
        else
        {
            transform.LookAt(playerT);
            if (Vector3.Distance(transform.position, playerT.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            }
        }

    }
}
