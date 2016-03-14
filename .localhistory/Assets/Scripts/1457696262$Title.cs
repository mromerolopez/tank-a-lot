using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	// Use this for initialization
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
