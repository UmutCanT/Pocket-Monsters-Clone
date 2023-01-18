using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class battle_scene_ui
{
    [Test]
    public void Player_Battle_UI_Info()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        GameObject battleHud = GameObject.FindGameObjectWithTag("PlayerHud");
        PokemonBattleHud battleHud1 = battleHud.GetComponent<PokemonBattleHud>();

        pokemonTemp.PokemonName = "Charizard";
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);
        battleHud1.UpdatePokemonBattleHud(playerPokemon);

        Assert.AreEqual("Charizard", battleHud1.PokemonNameText);
        Assert.AreEqual("Lv.78", battleHud1.PokemonLevelText);      
    }

    [Test]
    public void Player_Battle_UI_HP() 
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        GameObject battleHud = GameObject.FindGameObjectWithTag("PlayerHud");
        PokemonBattleHud battleHud1 = battleHud.GetComponent<PokemonBattleHud>();

        pokemonTemp.MaxHealthPoint = 108;
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);
        playerPokemon.CurrentHP = 105;
        battleHud1.UpdatePokemonBattleHud(playerPokemon);

        Assert.AreEqual(105, battleHud1.HpBar.CurrentValue());
        Assert.AreEqual(289, battleHud1.HpBar.MaxHPValue());
        Assert.AreEqual("105/ 289", battleHud1.HpBar.HpText());
    }

    [Test]
    public void Opponent_Battle_UI_Info()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        GameObject battleHud = GameObject.FindGameObjectWithTag("OpponentHud");
        PokemonBattleHud battleHud1 = battleHud.GetComponent<PokemonBattleHud>();

        pokemonTemp.PokemonName = "Blastoise";
        Pokemon opponentPokemon = new Pokemon(pokemonTemp, 78);
        battleHud1.UpdatePokemonBattleHud(opponentPokemon);

        Assert.AreEqual("Blastoise", battleHud1.PokemonNameText);
        Assert.AreEqual("Lv.78", battleHud1.PokemonLevelText);
    }

    [Test]
    public void Opponent_Battle_UI_HP()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        GameObject battleHud = GameObject.FindGameObjectWithTag("OpponentHud");
        PokemonBattleHud battleHud1 = battleHud.GetComponent<PokemonBattleHud>();

        pokemonTemp.MaxHealthPoint = 108;
        Pokemon opponentPokemon = new Pokemon(pokemonTemp, 78);
        opponentPokemon.CurrentHP = 25;
        battleHud1.UpdatePokemonBattleHud(opponentPokemon);

        Assert.AreEqual(25, battleHud1.HpBar.CurrentValue());
        Assert.AreEqual(289, battleHud1.HpBar.MaxHPValue());
    }
}
