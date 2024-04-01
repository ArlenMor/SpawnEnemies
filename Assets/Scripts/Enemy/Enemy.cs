using System.Drawing;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour, IMoveble
{
    [SerializeField] private EnemyData _enemyData;

    private Transform _target;
    private Animator _animator;
    public float Speed;  

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        Speed = _enemyData.SpeedData.IdleSpeed;
    }

    private void Update()
    {
        if (_target != null)
        {
            MoveTo(_target);

            if (transform.position == _target.position)
            {
                _target = null;

                Speed = _enemyData.SpeedData.IdleSpeed;
                _animator.SetFloat("SpeedAnim", Speed);
            }
                
        }
    }

    public void MoveTo(Transform point)
    {
        if (point == null)
            return;

        Speed = _enemyData.SpeedData.RunningSpeed;
        _animator.SetFloat("SpeedAnim", Speed);

        transform.LookAt(point);
        transform.position = Vector3.MoveTowards(transform.position, point.position, Speed * Time.deltaTime);
    }

    public void SetTarget(Transform target) => _target = target;
}