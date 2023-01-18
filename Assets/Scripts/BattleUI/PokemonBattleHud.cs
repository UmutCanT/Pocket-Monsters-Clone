using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokemonBattleHud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pokemonNameText;
    [SerializeField] TextMeshProUGUI pokemonLevelText;
    [SerializeField] Image pokemonGenderImage;
    [SerializeField] HealthBar hpBar;
    [SerializeField] PokemonBattleUnit pokemonUnit;

    readonly string levelTextTemplate = "Lv.{0}";

    public string PokemonNameText { get => pokemonNameText.text; }
    public string PokemonLevelText { get => pokemonLevelText.text; }
    public HealthBar HpBar { get => hpBar; }
    public PokemonBattleUnit PokemonUnit { get => pokemonUnit; }

    public void UpdatePokemonBattleHud(Pokemon pokemon)
    {
        pokemonNameText.text = pokemon.PokemonTemplate.PokemonName;
        pokemonLevelText.text = string.Format(levelTextTemplate, pokemon.CurrentLevel);
        hpBar.SetInitialHP(pokemon.CurrentHP, pokemon.MaxHP);
        pokemonUnit.SetPokemonImage(pokemon);
        //Gender
    }

}
