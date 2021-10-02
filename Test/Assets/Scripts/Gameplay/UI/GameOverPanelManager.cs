using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelManager : MonoBehaviour
{
    [SerializeField]
    GameObject gamePanel;

    [SerializeField]
    GameObject gameOverPanel;

    [SerializeField]
    SpriteRenderer background;

    [SerializeField]
    UnityEngine.UI.Text gameOverText;

    [SerializeField]
    UnityEngine.UI.Text scoreText;

    [SerializeField]
    UnityEngine.UI.Button restartButton;

    [SerializeField]
    Gameplay.ShipSystems.HealthSystem playerHealth;

    private bool show = false;

    void Update()
    {
        if (!show && ((playerHealth == null) || (playerHealth._health <= 0)))
        {
            Show();
        }
        if (show)
        {
            background.color = background.color + new Color(0,0,0,0.05f);
            if (background.color.a > 0.99f)
            {
                gameOverText.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(true);
                scoreText.text = "Score: " + ScoreManager.totalPoints.ToString();
                restartButton.gameObject.SetActive(true);
                show = false;
            }
        }
    }

    public void Show()
    {
        show = true;
        gamePanel.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("SampleScene");
        /*background.color = new Color(background.color.r, background.color.g, background.color.b, 0f);
        gamePanel.gameObject.SetActive(true);
        gameOverPanel.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);*/
    }
}
