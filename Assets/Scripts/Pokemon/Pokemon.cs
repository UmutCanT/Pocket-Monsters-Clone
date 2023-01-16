using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    public PokemonTemplate PokemonTemplate { get; private set; }
    public int CurrentLevel { get; private set; }
    public int CurrentHP { get; set; }
    public int CurrentAtt { get; set; }
    public int CurrentDef { get; set; }
    public int CurrentSpeA { get; set; }
    public int CurrentSpeD { get; set; }
    public int CurrentSpeed { get; set; }
    public List<Move> CurrentMoves { get; set; }


    public Pokemon(PokemonTemplate pokemonTemplate, int level)
    {
        this.PokemonTemplate = pokemonTemplate;
        CurrentLevel = level;
        CurrentHP = MaxHP;

        //Generating Moves
        CurrentMoves= new List<Move>();
        foreach (var move in pokemonTemplate.Moveset)
        {
            if (move.Level <= CurrentLevel)
                CurrentMoves.Add(new Move(move.MoveTemplete));

            if (CurrentMoves.Count >= 4)
                break;
        }
    }

    public int MaxHP { get { return Mathf.FloorToInt( (PokemonTemplate.MaxHealthPoint * CurrentLevel) / 100f) + 10; } }
    public int Attack { get { return Mathf.FloorToInt( (PokemonTemplate.Attack * CurrentLevel) / 100f) + 5; } }
    public int Defence { get { return Mathf.FloorToInt( (PokemonTemplate.Defence * CurrentLevel) / 100f) + 5; } }
    public int SpecialAtt { get { return Mathf.FloorToInt( (PokemonTemplate.SpecialAttack * CurrentLevel) / 100f) + 5; } }
    public int SpecialDef { get { return Mathf.FloorToInt( (PokemonTemplate.SpecialDefence * CurrentLevel) / 100f) + 5; } }
    public int Speed { get { return Mathf.FloorToInt( (PokemonTemplate.Speed * CurrentLevel) / 100f) + 5; } }

}
