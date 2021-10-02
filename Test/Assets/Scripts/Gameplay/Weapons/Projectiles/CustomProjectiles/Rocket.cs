using System.Collections;
using System.Collections.Generic;
using Gameplay.Weapons.Projectiles;
using UnityEngine;

public class Rocket : Projectile
{
    private void Start()
    {
        
    }

    protected override void Move(float speed)
    {
        transform.Translate(speed * Time.deltaTime * Vector3.up);
    }
}
