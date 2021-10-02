using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.ShipSystems
{

    public class HealthSystem : MonoBehaviour
    {
        [SerializeField]
        private ScoreIncreaser score;

        [SerializeField]
        private PowerupSpawner powerups;

        [SerializeField]
        public float _maxHealth;

        [SerializeField]
        public float _health;

        public void Heal(float amount)
        {
            _health += amount;
            if (_health > _maxHealth)
                _health = _maxHealth;
        }

        public void GetDamage(float damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                powerups?.SpawnPowerups();
                score?.SendScoreIncreaseMessage();
                Destroy(gameObject);
            }
        }
    }
}
