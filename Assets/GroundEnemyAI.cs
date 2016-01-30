using UnityEngine;
using System.Collections;

public class GroundEnemyAI : MonoBehaviour {

	GameObject player = null;
	Transform playerT = null;
	float MoveSpeed = 4;
	float MaxDist = 10;
	float MinDist = 1;
	public float health = 100;

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
		if(player == null)
		{
			player = GameObject.FindGameObjectWithTag("Ground");
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
			else
			{
				player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().health -= 10;
			}
		}

	}
}
