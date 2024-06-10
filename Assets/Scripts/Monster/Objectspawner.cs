using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    public GameObject objectPrefab; // 생성할 오브젝트
    public float spawnInterval = 30.0f; // 생성 간격
    public Vector3[] spawnPoints; // 생성할 수 있는 좌표들

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        if (spawnPoints.Length == 0) return;

        int randomIndex = Random.Range(0, spawnPoints.Length);
        Vector3 spawnPosition = spawnPoints[randomIndex];
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

        // 효과음 재생
        GetComponent<AudioSource>().Play();
    }
}
