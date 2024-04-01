using System.Collections;
using System.Linq;
using UnityEngine;

public class EnemysSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField, Min(1)] private float _spawnDelay = 1;
    [SerializeField] GameObject[] _enemyPrefabs;

    [SerializeField] GameObject[] _arrivalPoint;

    private WaitForSeconds _delay;

    private void Awake()
    {
        _delay = new WaitForSeconds(_spawnDelay);
        
    }

    private void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

    private IEnumerator Spawn()
    {
        while(enabled)
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count())];
            GameObject enemyUnit = Instantiate(_enemyPrefabs[0], spawnPoint.position, Quaternion.identity, transform.parent);

            enemyUnit.GetComponent<Enemy>().SetTarget(_arrivalPoint[Random.Range(0, _arrivalPoint.Count())].transform);

            yield return _delay;
        }
    }
}
