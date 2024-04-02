using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoint;

    private void Start()
    {
        _currentWaypoint = Random.Range(0, _waypoints.Length);
    }

    private void Update()
    {
        if(transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = Random.Range(0, _waypoints.Length);
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);
        transform.LookAt(_waypoints[_currentWaypoint].position);
    }
}