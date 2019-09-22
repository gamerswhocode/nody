using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoSpawner : MonoBehaviour
{
    public GameObject topoPrefab;
    public Transform player;
    public BoxCollider2D TopoSpawnAreaBoxCollider;
    public int NumberOfTopsInLevel;

    [Range(0, .25f)]
    public float spawnVerticalOffset;

    void Start()
    {
        StartCoroutine(WaitForTopoSpawn());
        NumberOfTopsInLevel = 5;
        //Instantiate(topoPrefab, player.position + Vector3.down * spawnVerticalOffset, Quaternion.identity);
    }
    private IEnumerator WaitForTopoSpawn()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(SpawnTopo());
    }

    private IEnumerator SpawnTopo()
    {
        while (NumberOfTopsInLevel > 0)
        {
            Vector3 minimumBound = TopoSpawnAreaBoxCollider.bounds.min;
            Vector3 maximumBound = TopoSpawnAreaBoxCollider.bounds.max;

            Vector2 spawnLocation = Vector2.zero;
            spawnLocation.x = Random.Range(minimumBound.x, maximumBound.x);
            spawnLocation.y = Random.Range(minimumBound.y, maximumBound.y);

            Instantiate(topoPrefab, spawnLocation, Quaternion.identity);
            yield return new WaitForSeconds(4f);
            --NumberOfTopsInLevel;
        }
    }
}
