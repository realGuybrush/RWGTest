using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> powerups;

    [SerializeField]
    private List<int> chances;

    public void SpawnPowerups()
    {
        for (int i = 0; i < powerups.Count; i++)
        {
            if (Random.Range(0, 100) < chances[i])
            {
                Instantiate(powerups[i], transform.position, transform.rotation);
            }
        }
    }
}
