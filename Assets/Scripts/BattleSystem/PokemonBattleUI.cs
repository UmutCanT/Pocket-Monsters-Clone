using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBattleUI : MonoBehaviour
{
    [SerializeField] PokemonBattleHud playerBattleHud;
    [SerializeField] PokemonBattleHud opponentBattleHud;

    [SerializeField] HealthBar playerUnitHPBar;
    [SerializeField] HealthBar opponentUnitHPBar;

    [SerializeField] BattleUnitUI playerUnitSprite;
    [SerializeField] BattleUnitUI opponentUnitSprite;

    public void BattleUiInitializer(Pokemon playerPok, Pokemon opponentPok)
    {
        PlayerSideSetup(playerPok);
        OpponentSideSetup(opponentPok);
    }

    void PlayerSideSetup(Pokemon pokemon)
    {
        playerUnitSprite.SetPokemonImage(pokemon);
        playerBattleHud.BattleHudInitializer(pokemon);
        playerUnitHPBar.HealthBarInitializer(pokemon);
    }

    void OpponentSideSetup(Pokemon pokemon)
    {
        opponentUnitSprite.SetPokemonImage(pokemon);
        opponentBattleHud.BattleHudInitializer(pokemon);
        opponentUnitHPBar.HealthBarInitializer(pokemon);
    }

    #region Tests;
    //TESTS
    public PokemonBattleHud PlayerBattleHud { get => playerBattleHud; }
    public PokemonBattleHud OpponentBattleHud { get => opponentBattleHud; }
    public HealthBar PlayerUnitHPBar { get => playerUnitHPBar; }
    public HealthBar OpponentUnitHPBar { get => opponentUnitHPBar; }
    public BattleUnitUI PlayerUnitSprite { get => playerUnitSprite; }
    public BattleUnitUI OpponentUnitSprite { get => opponentUnitSprite; }

    #endregion
}
