using UnityEditor.Animations;
using UnityEngine;

public class UnitData : ScriptableObject
{
    [SerializeField] private AnimatorController _animator;
    [SerializeField] private float _speed;

    public AnimatorController Animator => _animator; 
    public float Speed => _speed;
}
