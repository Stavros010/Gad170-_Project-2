using UnityEngine;

public class HazardScript : MonoBehaviour
{
    [Header("Coin Settings")]
    [Tooltip("The original hazard prefab to duplicate.")]
    public GameObject hazard;

    [Header("Spawn Locations")]
    [Tooltip("Assign empty GameObjects here to set spawn positions.")] // need these to add them inside the inspector
    public Transform[] hazardSpawnPoints;
    //use [] for position/scale or rotation

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        // Safety check to ensure references are assigned
        if (hazard == null || hazardSpawnPoints.Length == 0)
        {
            Debug.LogWarning("need to spawn hazards and assign");
            return;
        }

        // Loop through every spawn point in the array
        for (int i = 0; i < hazardSpawnPoints.Length; i++)
        {
            if (hazardSpawnPoints[i] != null)
            {
                // Duplicate the prefab at the specific position and rotation
                Instantiate(hazard, hazardSpawnPoints[i].position, hazardSpawnPoints[i].rotation);

            }
        }
    }
}
