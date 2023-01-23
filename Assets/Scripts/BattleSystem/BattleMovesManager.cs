using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMovesManager : MonoBehaviour
{
    [SerializeField] List<Button> moveButtons;
    [SerializeField] Sprite[] sprite;

    void AssignMoves(List<Move> moves)
    {
        for (int i = 0; i < moveButtons.Count; i++)
        {
            if (i < moves.Count)
            {

            }
        }
    }

    void ButtonSprites(Button button, Move move)
    {
        //button.image.sprite = move.;
    }

    public void Test()
    {
        for (int i = 0; i < moveButtons.Count; i++)
        {
            moveButtons[i].image.sprite = sprite[i];
        }
    }
}
