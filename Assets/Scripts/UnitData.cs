using UnityEditor.Animations;
using UnityEngine;

public class UnitData : ScriptableObject
{
    [SerializeField] SpeedData _speedData;

    public SpeedData SpeedData => _speedData;
}
