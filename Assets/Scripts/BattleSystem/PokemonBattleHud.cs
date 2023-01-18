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

    readonly string levelTextTemplate = "Lv.{0}";

    public string PokemonNameText { get => pokemonNameText.text; }
    public string PokemonLevelText { get => pokemonLevelText.text; }
    
    public void BattleHudInitializer(Pokemon pokemon)
    {
        pokemonNameText.text = pokemon.PokemonTemplate.PokemonName;
        pokemonLevelText.text = string.Format(levelTextTemplate, pokemon.CurrentLevel);      
        //Gender
    }

}
