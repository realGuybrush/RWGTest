using Gameplay.Powerups;
using Gameplay.Spaceships;
using UnityEngine;

public class GunBoostPowerup : Powerup
{
    [SerializeField]
    private float atkSpdBoost;

    [SerializeField]
    private float atkSpdBoostPeroid;

    public override void Action(Spaceship player)
    {
        player.WeaponSystem.BoostGuns(atkSpdBoost, atkSpdBoostPeroid);
        base.Action(player);
    }
}
