using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonCommandUI : MonoBehaviour
{
    [SerializeField] GameObject actionsUI;
    [SerializeField] GameObject movesUI;
    [SerializeField] BattleDialogManager battleDialogs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowActionsUI(bool state)
    {
        actionsUI.SetActive(state);
    } 
    public void ShowMovesUI(bool state)
    {
        movesUI.SetActive(state);
    } 
    public void ShowBattleDialogs(bool state)
    {
        battleDialogs.gameObject.SetActive(state);
    }

    public void SetDialog(string text)
    {
        StartCoroutine(battleDialogs.TypeAnimatedDialog(text));
    }
}