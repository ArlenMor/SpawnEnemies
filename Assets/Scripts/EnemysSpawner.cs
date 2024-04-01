using System.Collections;
using System.Linq;
using UnityEngine;

public class EnemysSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField, Min(1)] private float _spawnDelay = 1;

    [SerializeField] private Enemy[] _enemyPrefabs;
    [SerializeField] private Transform[] _arrivalPoints;

    private WaitForSeconds _delay;

    private void Start()
    {
        _delay = new WaitForSeconds(_spawnDelay);
        StartCoroutine(nameof(Spawn));
    }

    private IEnumerator Spawn()
    {
        while(enabled)
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count())];
            Enemy enemy = Instantiate(_enemyPrefabs[Random.Range(0, _enemyPrefabs.Count())], 
                                        spawnPoint.position, 
                                        Quaternion.identity, 
                                        transform.parent);

            enemy.Init(_arrivalPoints[Random.Range(0, _arrivalPoints.Count())].position);

            yield return _delay;
        }
    }
}
