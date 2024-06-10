using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;
    public float spawnIntervalMin = 30f;
    public float spawnIntervalMax = 40f;
    public float enemyLifeTime = 10f;
    public AudioClip spawnSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            float spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            yield return new WaitForSeconds(spawnInterval);

            Vector3 spawnPosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            audioSource.PlayOneShot(spawnSound);

            EnemyController enemyController = enemy.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.Initialize(player, enemyLifeTime);
            }
        }
    }
}
