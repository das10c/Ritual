using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MySceneManager : MonoBehaviour {

    public static void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }
}
