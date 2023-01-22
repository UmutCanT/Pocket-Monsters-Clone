using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BattleState
{
    protected BattleStateManager stateManager;
    protected Contanders contanders;

    public BattleState(BattleStateManager stateManager, Contanders contanders)
    {
        this.stateManager = stateManager;
        this.contanders= contanders;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator UsingMove()
    {
        yield break;

    }

    public virtual IEnumerator UsingItem()
    {
        yield break;

    }

    public virtual IEnumerator SwitchingPokemon()
    {
        yield break;

    }

    public virtual IEnumerator RunningAway()
    {
        yield break;

    }
}

public class StartOfBattle : BattleState
{
    public StartOfBattle(BattleStateManager stateManager, Contanders contanders) 
        : base(stateManager, contanders)
    {
    }

    public override IEnumerator Start()
    {

        //Check whather opponent is just a pokemon or a trainer
        stateManager.PokemonCommandUI.ShowBattleDialogs(true);
        stateManager.PokemonCommandUI.SetDialog($"A wild {contanders.OpponentPokemon.PokemonName} appeared");
        yield return new WaitForSeconds(2f);
        stateManager.SetBattleState(new PlayerTurn(stateManager, contanders));
    }
}

public class PlayerTurn : BattleState
{
    public PlayerTurn(BattleStateManager stateManager, Contanders contanders) 
        : base(stateManager, contanders)
    {
    }

    public override IEnumerator Start() 
    {
        stateManager.PokemonCommandUI.SetDialog("Choose an action");
        stateManager.PokemonCommandUI.ShowActionsUI(true);
        stateManager.PokemonBattleUI.BattleUiInitializer(contanders.PlayerPokemon, contanders.OpponentPokemon);
        return base.Start();
    }

    public override IEnumerator UsingMove()
    {
        Debug.Log("Move Used");
        stateManager.SetBattleState(new OpponentTurn(stateManager, contanders));
        return base.UsingMove();
    }
}