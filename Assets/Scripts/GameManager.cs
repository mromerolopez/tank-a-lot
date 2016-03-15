using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject WinPanel;
    [SerializeField]
    private GameObject LosePanel;
    [SerializeField]
    private string nextLvl;

    [SerializeField]
    private GameObject life1;
    [SerializeField]
    private GameObject life2;
    [SerializeField]
    private GameObject life3;

    [SerializeField]
    private Text ScoreText;

    [SerializeField]
    private int PointsToWin = 700;

    private int score = 0;
    private int lifes = 3;

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

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLvl);
    }

    public void PlayerDestroyed()
    {
        lifes--;
        if (lifes == 2)
        {
            life3.SetActive(false);
        }
        if (lifes == 1)
        {
            life2.SetActive(false);
        }
        if (lifes == 0)
        {
            life1.SetActive(false);
            Lose();
        }
    }

    public void addScore(int score)
    {
        this.score += score;
        ScoreText.text = "Score: " + this.score.ToString();
        if (this.score >= PointsToWin)
        {
            Win();
        }
    }
}
