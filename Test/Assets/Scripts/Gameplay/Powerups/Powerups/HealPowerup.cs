using Gameplay.Powerups;
using Gameplay.Spaceships;
using UnityEngine;

public class HealPowerup : Powerup
{
    [SerializeField]
    private float healAmount;


    public override void Action(Spaceship player)
    {
        player.HealthSystem.Heal(healAmount);
        base.Action(player);
    }
}