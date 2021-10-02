﻿using System.Collections.Generic;
using Gameplay.Weapons;
using UnityEngine;
using System.Linq;

namespace Gameplay.ShipSystems
{
    public class WeaponSystem : MonoBehaviour
    {

        [SerializeField]
        private List<Weapon> _weapons;



        public void Init(UnitBattleIdentity battleIdentity)
        {
            _weapons.ForEach(w => w.Init(battleIdentity));
        }
        
        
        public void TriggerFire()
        {
            _weapons.ForEach(w => w.TriggerFire());
        }

        public void BoostGuns(float boost, float boostTime)
        {
            for (int i = 0; i < _weapons.Count; i++)
            {
                _weapons[i].BoostWeapon(boost, boostTime);
            }
        }

    }
}
