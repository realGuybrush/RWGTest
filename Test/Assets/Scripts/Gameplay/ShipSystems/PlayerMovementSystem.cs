using Gameplay.Helpers;
using UnityEngine;

namespace Gameplay.ShipSystems
{
    public class PlayerMovementSystem : MovementSystem
    {
        [SerializeField]
        private SpriteRenderer _representation;


        override public void LateralMovement(float amount)
        {
            if (GameAreaHelper.WillPlayerLeaveGameplayArea(transform, _representation.bounds, amount * _lateralMovementSpeed * Vector3.right.normalized))
                Move(amount * _lateralMovementSpeed, Vector3.right);
        }
    }
}

