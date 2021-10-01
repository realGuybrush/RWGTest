using System.Collections;
using System.Collections.Generic;
using Gameplay.Helpers;
using UnityEngine;

public class OutOfBorderStopper : MonoBehaviour
{

    [SerializeField]
    private SpriteRenderer _representation;

    void Update()
    {
        CheckBorders();
    }

    private void CheckBorders()
    {
        if (!GameAreaHelper.IsInGameplayArea(transform, _representation.bounds))
        {
            ;
        }
    }
}
