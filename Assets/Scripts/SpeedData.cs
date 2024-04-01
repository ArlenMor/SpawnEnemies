using System;
using UnityEngine;

[Serializable]
public class SpeedData
{
    [SerializeField, Range(0.1f, 3)] private float _walkingSpeed = 3;
    [SerializeField, Range(3.1f, 6)] private float _runningSpeed = 6;
    
    public readonly float IdleSpeed = 0;
    public float WalkingSpeed => _walkingSpeed;
    public float RunningSpeed => _runningSpeed;
}