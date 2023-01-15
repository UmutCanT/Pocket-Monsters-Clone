using UnityEngine;

[System.Serializable]
public class LearnableMoveset
{
    [SerializeField] int level;
    [SerializeField] MoveTemplate moveTemplete;

    public int Level { get => level; }
    public MoveTemplate MoveTemplete { get => moveTemplete; }
}