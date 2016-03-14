using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject WinPanel;
    [SerializeField]
    private GameObject LosePanel;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Win()
    {
        WinPanel.SetActive(true);
        Image image = WinPanel.GetComponent<Image>();
    }
}
