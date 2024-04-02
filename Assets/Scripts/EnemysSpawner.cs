using System.Collections;
using System.Linq;
using UnityEngine;

public class EnemysSpawner : MonoBehaviour
{
    [SerializeField, Min(1)] private float _spawnDelay = 1;

    [SerializeField] private Enemy _enemyPrefabs;
    [SerializeField] private Transform _target;

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
            Enemy enemy = Instantiate(_enemyPrefabs, 
                                        transform.position, 
                                        Quaternion.identity, 
                                        transform.parent);

            enemy.Init(_target);

            yield return _delay;
        }
    }
}
