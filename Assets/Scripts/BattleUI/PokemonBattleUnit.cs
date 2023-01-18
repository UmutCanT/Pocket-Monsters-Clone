using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonBattleUnit : MonoBehaviour
{
    [SerializeField] Image pokemonImage;
    [SerializeField] bool isPlayerPokemon;

    public void SetPokemonImage(Pokemon pokemon)
    {
        if (isPlayerPokemon)
        {
            pokemonImage.sprite = pokemon.PokemonTemplate.BackSprite;
        }
        else
        {
            pokemonImage.sprite = pokemon.PokemonTemplate.FrontSprite;
        }
    }

    //Test
    public string SpriteName() => pokemonImage.sprite.name;
}
