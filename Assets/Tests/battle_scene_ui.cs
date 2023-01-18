using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class battle_scene_ui
{
    [SetUp]
    public void Test_Setup()
    {
        var playerPokemonTemp = Resources.Load("Pokemon/Charizard") as PokemonTemplate;
        var opponentPokemonTemp = Resources.Load("Pokemon/Blastoise") as PokemonTemplate;
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Pokemon playerPokemon = new Pokemon(playerPokemonTemp, 63);
        Pokemon opponentPokemon = new Pokemon(opponentPokemonTemp, 71);

        playerPokemon.CurrentHP = 105;
        opponentPokemon.CurrentHP = 25;

        battleUi.BattleUiInitializer(playerPokemon, opponentPokemon);      
    }

    //Player Side
    [Test]
    public void Player_Battle_Hud_Info()
    {
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual("Charizard", battleUi.PlayerBattleHud.PokemonNameText);
        Assert.AreEqual("Lv.63", battleUi.PlayerBattleHud.PokemonLevelText);      
    }

    [Test]
    public void Player_Battle_UI_HP() 
    {
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual(105, battleUi.PlayerUnitHPBar.CurrentValue());
        Assert.AreEqual(197, battleUi.PlayerUnitHPBar.MaxHPValue());
        Assert.AreEqual("105/ 197", battleUi.PlayerUnitHPBar.HpText());
    }

    [Test]
    public void Player_Battle_Unit()
    {   
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual("6Back", battleUi.PlayerUnitSprite.SpriteName());
    }

    //Opponent Side
    [Test]
    public void Opponent_Battle_Hud_Info()
    {    
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual("Blastoise", battleUi.OpponentBattleHud.PokemonNameText);
        Assert.AreEqual("Lv.71", battleUi.OpponentBattleHud.PokemonLevelText);
    }

    [Test]
    public void Opponent_Battle_UI_HP()
    {
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual(25, battleUi.OpponentUnitHPBar.CurrentValue());
        Assert.AreEqual(223, battleUi.OpponentUnitHPBar.MaxHPValue());
    }

    [Test]
    public void Opponent_Battle_Unit()
    {
        PokemonBattleUI battleUi = GameObject.FindGameObjectWithTag("BattleSetup").GetComponent<PokemonBattleUI>();

        Assert.AreEqual("9Front", battleUi.OpponentUnitSprite.SpriteName());
    }
}
