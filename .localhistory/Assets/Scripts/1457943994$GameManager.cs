using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject WinPanel;
    [SerializeField]
    private GameObject LosePanel;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Win()
    {
        WinPanel.SetActive(true);
        Image image = WinPanel.GetComponent<Image>();
        image.CrossFadeAlpha(0, 0, false);
        image.CrossFadeAlpha(1, 1.5f, false);
    }

    public void Lose()
    {
        LosePanel.SetActive(true);
        Image image = LosePanel.GetComponent<Image>();
        image.CrossFadeAlpha(0, 0, false);
        image.CrossFadeAlpha(1, 1.5f, false);
    }

}
