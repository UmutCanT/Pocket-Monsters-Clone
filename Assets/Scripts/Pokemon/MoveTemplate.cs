using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveTemplete", menuName = "Moves/Create new moveTemplete")]
public class MoveTemplate : ScriptableObject
{
    [SerializeField] int moveId;
    [SerializeField] string moveName;
    [TextArea][SerializeField] string moveDescription;

    [SerializeField] PokemonTypes moveType;
    [SerializeField] MoveCategories moveCategory;
    [SerializeField] int powerPoint;
    [SerializeField] int power;
    [SerializeField] int accuracy;

    public int MoveId { get => moveId; }
    public string MoveName { get => moveName;  }
    public string MoveDescription { get => moveDescription; }
    public PokemonTypes MoveType { get => moveType; }
    public MoveCategories MoveCategory { get => moveCategory; }
    public int PowerPoint { get => powerPoint; }
    public int Power { get => power; }
    public int Accuracy { get => accuracy; }
}   
