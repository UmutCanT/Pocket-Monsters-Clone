using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class pokemon_attributes_checker
{
    [Test]
    public void Pokemon_Hp_according_to_Level()
    {       
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.MaxHealthPoint= 108;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(289, playerPokemon.MaxHP);
    }

    [Test]
    public void Pokemon_Attack_according_to_Level()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.Attack = 130;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(278, playerPokemon.Attack);
    }

    [Test]
    public void Pokemon_Defence_according_to_Level()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.Defence = 95;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(193, playerPokemon.Defence);
    }

    [Test]
    public void Pokemon_Spe_Attack_according_to_Level()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.SpecialAttack = 80;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(135, playerPokemon.SpecialAtt);
    }

    [Test]
    public void Pokemon_Spe_Def_according_to_Level()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.SpecialDefence = 85;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(171, playerPokemon.SpecialDef);
    }

    [Test]
    public void Pokemon_Speed_according_to_Level()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        pokemonTemp.Speed = 102;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);

        Assert.AreEqual(171, playerPokemon.Speed);
    }
}
