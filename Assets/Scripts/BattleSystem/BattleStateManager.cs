using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateManager : MonoBehaviour
{
    BattleStates battleState;
    [SerializeField] PokemonBattleUI pokemonBattleUI;
    [SerializeField] PokemonCommandUI pokemonCommandUI;

    // Start is called before the first frame update
    void Start()
    {
        battleState = BattleStates.Start;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartofBattle()
    {
        pokemonCommandUI.ShowBattleDialogs(true);
    }
}
