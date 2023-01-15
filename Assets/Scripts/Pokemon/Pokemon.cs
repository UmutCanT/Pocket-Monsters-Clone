using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    PokemonTemplate pokemonTemplate;
    int level;

    public Pokemon(PokemonTemplate pokemonTemplate, int level)
    {
        this.pokemonTemplate = pokemonTemplate;
        this.level = level;
    }

    public int MaxHP { get { return Mathf.FloorToInt( (pokemonTemplate.MaxHealthPoint * level )/ 100f) + 10; } }
    public int Attack { get { return Mathf.FloorToInt( (pokemonTemplate.Attack * level )/ 100f) + 5; } }
    public int Defence { get { return Mathf.FloorToInt( (pokemonTemplate.Defence * level )/ 100f) + 5; } }
    public int SpecialAtt { get { return Mathf.FloorToInt( (pokemonTemplate.SpecialAttack * level )/ 100f) + 5; } }
    public int SpecialDef { get { return Mathf.FloorToInt( (pokemonTemplate.SpecialDefence * level )/ 100f) + 5; } }
    public int Speed { get { return Mathf.FloorToInt( (pokemonTemplate.Speed * level )/ 100f) + 5; } }

}
