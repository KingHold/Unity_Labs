using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public int _waveSize;

    public GameObject _enemyPrefab;

    public float _enemyInterval;

    public Transform _spawnPoint;

    public float _startTime;

    int _enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", _startTime, _enemyInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemyCount == _waveSize)
        {
            CancelInvoke("SpawnEnemy");
        }
    }

    void SpawnEnemy()
    {
        _enemyCount++;
        GameObject _enemy = GameObject.Instantiate(_enemyPrefab, _spawnPoint.position, Quaternion.identity) as GameObject;
    }
}
