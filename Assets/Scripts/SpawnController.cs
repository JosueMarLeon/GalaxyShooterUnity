using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Vector3 spawnReferencePosition;
    [SerializeField] int amountToSpawn;

    Vector3 randomPosition;
    void Start()
    {
        //for (int i = 0; i < amountToSpawn; i++) 
        //{
        //    randomPosition = new Vector3(
        //        Random.Range(-spawnReferencePosition.x,spawnReferencePosition.x),
        //        spawnReferencePosition.y, 
        //        spawnReferencePosition.z);
        //    StartCoroutine(SpawnEnemyWays());

        //    //SpawnEnemy(randomPosition);
        //}

        StartCoroutine(SpawnEnemyWays());
    }

    private IEnumerator SpawnEnemyWays() 
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            randomPosition = new Vector3(
                Random.Range(-spawnReferencePosition.x, spawnReferencePosition.x),
                spawnReferencePosition.y,
                spawnReferencePosition.z);
            SpawnEnemy();
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(0.5f);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
