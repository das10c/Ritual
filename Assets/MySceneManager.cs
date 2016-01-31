using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MySceneManager : MonoBehaviour {

    public static void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }

    public static void LoadLevel()
    {
        SceneManager.LoadScene("Build Level 1");
        SceneManager.LoadScene("UIScene", LoadSceneMode.Additive);
    }
}
