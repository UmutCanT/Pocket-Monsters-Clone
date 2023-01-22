using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contanders : MonoBehaviour
{
    Pokemon playerPokemon;
    Pokemon opponentPokemon;

    public Pokemon PlayerPokemon { get => playerPokemon; set => playerPokemon = value; }
    public Pokemon OpponentPokemon { get => opponentPokemon; set => opponentPokemon = value; }

    private void Awake()
    {
        playerPokemon = new Pokemon(Resources.Load("Pokemon/Charizard") as PokemonTemplate, 63);
        opponentPokemon = new Pokemon(Resources.Load("Pokemon/Blastoise") as PokemonTemplate, 71);
    }
}
