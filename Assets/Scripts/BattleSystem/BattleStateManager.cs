using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleStateManager : MonoBehaviour
{
    BattleState battleState;
    [SerializeField] PokemonBattleUI pokemonBattleUI;
    [SerializeField] PokemonCommandUI pokemonCommandUI;
    [SerializeField] Contanders contanders;

    public PokemonBattleUI PokemonBattleUI { get => pokemonBattleUI; }
    public PokemonCommandUI PokemonCommandUI { get => pokemonCommandUI; }

    // Start is called before the first frame update
    void Start()
    {
        SetBattleState(new StartOfBattle(this, contanders));
    }

    public void OnMoveSelect()
    {
        StartCoroutine(battleState.UsingMove());
    }
    
    public void OnItemUse()
    {
        StartCoroutine(battleState.UsingItem());
    }
    
    public void OnPokemonSwitch()
    {
        StartCoroutine(battleState.SwitchingPokemon());
    }
    
    public void OnRunAway()
    {
        StartCoroutine(battleState.RunningAway());
    }

    public void SetBattleState(BattleState battleState)
    {
        this.battleState = battleState;
        StartCoroutine(this.battleState.Start());
    }
}
