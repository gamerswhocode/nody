using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoSpawner : MonoBehaviour
{
    public GameObject topoPrefab;
    public Transform player;

    [Range(0, .25f)]
    public float spawnVerticalOffset;

    void Start()
    {
        StartCoroutine(WaitForTopoSpawn());
    }
    private IEnumerator WaitForTopoSpawn()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(SpawnTopo());
    }

    private IEnumerator SpawnTopo()
    {
        while (true)
        {
            Instantiate(topoPrefab, player.position + Vector3.down * spawnVerticalOffset, Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }
}
