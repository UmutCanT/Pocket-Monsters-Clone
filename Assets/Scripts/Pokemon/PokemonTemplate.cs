using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Pokemon", menuName ="Pokemon/Create new pokemon")]
public class PokemonTemplate : ScriptableObject
{
    //Pokedex Entries
    [SerializeField] int pokemonId;
    [SerializeField] string pokemonName;
    [TextArea][SerializeField] string pokemonDescription;
    [SerializeField] PokemonTypes typeOne;
    [SerializeField] PokemonTypes typeTwo;

    //Visuals
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;
    [SerializeField] Sprite inGameSprite;

    //Pokemon Stats
    [SerializeField] int maxHealthPoint;
    [SerializeField] int attack;
    [SerializeField] int defence;
    [SerializeField] int specialAttack;
    [SerializeField] int specialDefence;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMoveset> moveset;

    public string PokemonName { get => pokemonName; }
    public int PokemonId { get => pokemonId; }
    public string PokemonDescription { get => pokemonDescription; }
    public PokemonTypes TypeOne { get => typeOne; }
    public PokemonTypes TypeTwo { get => typeTwo; }
    public Sprite FrontSprite { get => frontSprite; }
    public Sprite BackSprite { get => backSprite; }
    public Sprite InGameSprite { get => inGameSprite; }
    public int MaxHealthPoint { get => maxHealthPoint; }
    public int Attack { get => attack; }
    public int Defence { get => defence; }
    public int SpecialAttack { get => specialAttack; }
    public int SpecialDefence { get => specialDefence; }
    public int Speed { get => speed; }
    public List<LearnableMoveset> Moveset { get => moveset; }
}