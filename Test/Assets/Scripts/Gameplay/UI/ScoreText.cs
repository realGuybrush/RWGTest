using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private void Update()
    {
        if (ScoreManager.changed)
        {
            ScoreManager.changed = false;
            UpdateText();
        }
    }

    private void UpdateText()
    {
        scoreText.text = ScoreManager.totalPoints.ToString();
    }
}
