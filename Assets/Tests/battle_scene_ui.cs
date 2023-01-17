using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class battle_scene_ui
{
    [Test]
    public void battle_UI()
    {
        var pokemonTemp = ScriptableObject.CreateInstance<PokemonTemplate>();
        GameObject battleHud = GameObject.FindGameObjectWithTag("PlayerHud");
        PokemonBattleHud battleHud1 = battleHud.GetComponent<PokemonBattleHud>();

        pokemonTemp.MaxHealthPoint = 108;
        pokemonTemp.PokemonName = "Charizard";
        Pokemon playerPokemon = new Pokemon(pokemonTemp, 78);
        battleHud1.UpdatePokemonBattleHud(playerPokemon);

        Assert.AreEqual("Charizard", battleHud1.PokemonNameText);
        Assert.AreEqual("Lv.78", battleHud1.PokemonLevelText);
    }
}
