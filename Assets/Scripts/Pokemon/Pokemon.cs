using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    public string PokemonName { get; set; }
    public IPokemon PokemonTemplate { get; private set; }
    public int CurrentLevel { get; private set; }
    public int CurrentHP { get; set; }
    public int CurrentAtt { get; set; }
    public int CurrentDef { get; set; }
    public int CurrentSpeA { get; set; }
    public int CurrentSpeD { get; set; }
    public int CurrentSpeed { get; set; }
    public List<Move> CurrentMoves { get; set; }

    private readonly int[] temporaryIV = { 24, 12, 30, 16, 23, 5 };
    private readonly int[] temporaryEV = { 74, 190, 91, 48, 84, 23 };

    public Pokemon(IPokemon pokemonTemplate, int level)
    {
        PokemonTemplate = pokemonTemplate;
        CurrentLevel = level;
        PokemonName = pokemonTemplate.PokemonName;
        CurrentHP = MaxHP;

        //Generating Moves
        //CurrentMoves= new List<Move>();
        //foreach (var move in pokemonTemplate.Moveset)
        //{
        //    if (move.Level <= CurrentLevel)
        //        CurrentMoves.Add(new Move(move.MoveTemplete));

        //    if (CurrentMoves.Count >= 4)
        //        break;
        //}
    }

    public int MaxHP { get 
        { return Mathf.FloorToInt(Mathf.Floor((2 * PokemonTemplate.MaxHealthPoint + temporaryIV[0] + Mathf.Floor(temporaryEV[0] / 4f)) * CurrentLevel/ 100f) + CurrentLevel + 10); } }
    public int Attack { get 
        { return Mathf.FloorToInt((Mathf.Floor((2 * PokemonTemplate.Attack + temporaryIV[1] + Mathf.Floor(temporaryEV[1] / 4f)) * CurrentLevel / 100f) + 5) * 1.1f); } }
    public int Defence { get 
        { return Mathf.FloorToInt((Mathf.Floor((2 * PokemonTemplate.Defence + temporaryIV[2] + Mathf.Floor(temporaryEV[2] / 4f)) * CurrentLevel / 100f) + 5) * 1); } }
    public int SpecialAtt { get 
        { return Mathf.FloorToInt((Mathf.Floor((2 * PokemonTemplate.SpecialAttack + temporaryIV[3] + Mathf.Floor(temporaryEV[3] / 4f)) * CurrentLevel / 100f) + 5) * 0.9f); } }
    public int SpecialDef { get 
        { return Mathf.FloorToInt((Mathf.Floor((2 * PokemonTemplate.SpecialDefence + temporaryIV[4] + Mathf.Floor(temporaryEV[4] / 4f)) * CurrentLevel / 100f) + 5) * 1f); } }
    public int Speed { get 
        { return Mathf.FloorToInt((Mathf.Floor((2 * PokemonTemplate.Speed + temporaryIV[5] + Mathf.Floor(temporaryEV[5] / 4f)) * CurrentLevel / 100f) + 5) * 1f); } }

}
