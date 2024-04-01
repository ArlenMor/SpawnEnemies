using UnityEngine;

public class Enemy : MonoBehaviour, IMoveble
{
    [SerializeField] private EnemyData _enemyData;

    private Transform _target;
    public float Speed => _enemyData.Speed;

    private void Update()
    {
        if (_target != null)
        {
            transform.LookAt(_target);
            MoveTo(_target);
        }
    }

    public void MoveTo(Transform point)
    {
        transform.position = Vector3.MoveTowards(transform.position, point.position, Speed * Time.deltaTime);
    }

    public void SetTarget(Transform target) => _target = target;
}