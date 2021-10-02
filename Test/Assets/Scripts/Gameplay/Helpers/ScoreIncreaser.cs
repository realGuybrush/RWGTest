using System.Collections;
using System.Collections.Generic;
using Gameplay.Helpers;
using UnityEngine;

public class ScoreIncreaser : MonoBehaviour
{
    [SerializeField]
    private int _thisUnitScore;


    public void SendScoreIncreaseMessage()
    {
        ScoreManager.AddPoints(_thisUnitScore);
    }
}
