using UnityEngine;
using Gameplay.Spaceships;


namespace Gameplay.Powerups
{
    public abstract class Powerup : MonoBehaviour, IPowerup
    {
        [SerializeField]
        private float _speed;
        public virtual void Action(Spaceship player)
        {
            Destroy(this.gameObject);
        }


        private void Update()
        {
            Move(_speed);
        }


        private void OnCollisionEnter2D(Collision2D other)
        {
            var playerObject = other.gameObject.GetComponent<Spaceship>();

            if (playerObject != null)
            {
                Action(playerObject);
            }
        }
        protected void Move(float speed)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
    }
}
