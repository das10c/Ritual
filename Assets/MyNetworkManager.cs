using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class MyNetworkManager : NetworkManager {

    class MyManager : NetworkManager
    {
        public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
        {
            if (extraMessageReader != null)
            {
                var s = extraMessageReader.ReadMessage<StringMessage>();
                Debug.Log("my name is " + s.value);
            }
            OnServerAddPlayer(conn, playerControllerId, extraMessageReader);
        }
    }
}
