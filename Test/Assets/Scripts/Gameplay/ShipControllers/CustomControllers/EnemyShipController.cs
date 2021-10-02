using System.Collections;
using System.Collections.Generic;
using Gameplay.ShipControllers;
using Gameplay.ShipSystems;
using UnityEngine;

public class EnemyShipController : ShipController
{

    [SerializeField]
    private Vector2 _fireDelay;

    [SerializeField]
    private float maxLatSpd;

    private int spdRotCoeff = 0;

    private bool _fire = true;
    
    protected override void ProcessHandling(MovementSystem movementSystem)
    {
        movementSystem.LateralMovement(Time.deltaTime * LatSpdCoeff());
        movementSystem.LongitudinalMovement(Time.deltaTime);
    }

    private float LatSpdCoeff()
    {
        float spdCoeff = maxLatSpd * Mathf.Sin(spdRotCoeff * Mathf.Deg2Rad);
        spdRotCoeff+=5;
        if (spdRotCoeff > 360)
            spdRotCoeff = 0;
        return spdCoeff;
    }

    protected override void ProcessFire(WeaponSystem fireSystem)
    {
        if (!_fire)
            return;

        fireSystem.TriggerFire();
        StartCoroutine(FireDelay(Random.Range(_fireDelay.x, _fireDelay.y)));
    }


    private IEnumerator FireDelay(float delay)
    {
        _fire = false;
        yield return new WaitForSeconds(delay);
        _fire = true;
    }
}
