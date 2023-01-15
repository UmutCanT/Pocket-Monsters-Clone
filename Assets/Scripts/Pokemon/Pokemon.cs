using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Pokemon", menuName ="Pokemon/Create new pokemon")]
public class Pokemon : ScriptableObject
{
    //Pokedex Entries
    [SerializeField] string pokemonName;
    [SerializeField] int pokemonId;
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
}