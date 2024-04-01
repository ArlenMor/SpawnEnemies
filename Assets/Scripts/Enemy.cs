using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;

    private void Update()
    {
        if (_direction != null)
            Move(_direction);    
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
        transform.LookAt(direction);
    }

    private void Move(Vector3 direction)
    {
        if (direction == null)
            return;

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}