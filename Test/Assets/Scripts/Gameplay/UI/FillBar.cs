using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillBar : MonoBehaviour
{
    public RectTransform frame;
    public RectTransform bar;
    public Gameplay.ShipSystems.HealthSystem playerHealth;
    private float maxValue = 100;
    private float curValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        maxValue = playerHealth._maxHealth;
        curValue = playerHealth._health;
        UpdateBar();
    }

    // Update is called once per frame
    void Update()
    {
        if (curValue != playerHealth._health)
        {
            curValue = playerHealth._health;
            UpdateBar();
        }
    }

    public void UpdateBar()
    {
        float proportion = curValue / maxValue;
        bar.sizeDelta = new Vector2(frame.rect.width*proportion, bar.rect.height);
        bar.position = new Vector2(frame.position.x - frame.rect.width/2 + bar.rect.width/2, bar.position.y);
    }
}
