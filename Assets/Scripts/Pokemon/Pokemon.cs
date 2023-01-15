using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    PokemonTemplate pokemonTemplate;
    int currentLevel;

    public int CurrentHP { get; set; }
    public int CurrentAtt { get; set; }
    public int CurrentDef { get; set; }
    public int CurrentSpeA { get; set; }
    public int CurrentSpeD { get; set; }
    public int CurrentSpeed { get; set; }
    public List<Move> CurrentMoves { get; set; }


    public Pokemon(PokemonTemplate pokemonTemplate, int level)
    {
        this.pokemonTemplate = pokemonTemplate;
        currentLevel = level;
        CurrentHP = MaxHP;

        //Generating Moves
        CurrentMoves= new List<Move>();
        foreach (var move in pokemonTemplate.Moveset)
        {
            if (move.Level <= currentLevel)
                CurrentMoves.Add(new Move(move.MoveTemplete));

            if (CurrentMoves.Count >= 4)
                break;
        }
    }

    public int MaxHP { get { return Mathf.FloorToInt( (pokemonTemplate.MaxHealthPoint * currentLevel) / 100f) + 10; } }
    public int Attack { get { return Mathf.FloorToInt( (pokemonTemplate.Attack * currentLevel )/ 100f) + 5; } }
    public int Defence { get { return Mathf.FloorToInt( (pokemonTemplate.Defence * currentLevel )/ 100f) + 5; } }
    public int SpecialAtt { get { return Mathf.FloorToInt( (pokemonTemplate.SpecialAttack * currentLevel )/ 100f) + 5; } }
    public int SpecialDef { get { return Mathf.FloorToInt( (pokemonTemplate.SpecialDefence * currentLevel )/ 100f) + 5; } }
    public int Speed { get { return Mathf.FloorToInt( (pokemonTemplate.Speed * currentLevel )/ 100f) + 5; } }

}
