using UnityEngine;
using System.Collections;

public class AirEnemyAI : MonoBehaviour
{
    GameObject player = null;
    Transform playerT = null;

    public float MaxDist = 10;
    float MinDist = 1;
    public float health = 100;
    public float attackStrength = 10;
    public float attackRate = 1;
    public float moveSpeed = 4;
    health h;
    MusicController mc;

    float timer = 0;

    void Update()
    {
        chase();
        if (health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void chase()
    {
        timer += Time.deltaTime;
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Flying");
        }
        else if(playerT == null)
        {
            playerT = player.transform;
        }
        else if (Vector3.Distance(transform.position, playerT.position) <= MaxDist)
        {
            mc.isInCombat = true;
            transform.LookAt(playerT);
            if (Vector3.Distance(transform.position, playerT.position) >= MinDist)
            {

                transform.position += transform.forward * moveSpeed * Time.deltaTime;

            }
            else if (timer > attackRate)
            {
                h.updateHealth(-attackStrength);
                timer = 0;
            }
        }
    }

    void Start()
    {
        h = FindObjectOfType<health>();
        mc = FindObjectOfType<MusicController>();
    }
}
