using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    int spawnId = 0;
    GameObject spawner;

    public override void OnStartServer()
    {
        base.OnStartServer();
        spawnId = 0;
        spawner = GameObject.FindGameObjectWithTag("Respawn");
        if (spawner == null)
        {
            Debug.LogError("Add Player Spawer to level");
        }
        Vector3 temp = spawner.transform.position;
        temp.y = 1.1f;
        spawner.transform.position = temp;
    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        playerPrefab = spawnPrefabs[spawnId];
        base.OnServerAddPlayer(conn, playerControllerId);
        if (spawnId == 0)
        {
            Vector3 temp = spawner.transform.position;
            temp.y = 20;
            spawner.transform.position = temp;
            spawnId = 1;
        }
    }


}