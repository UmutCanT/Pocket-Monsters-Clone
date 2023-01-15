using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

[System.Serializable]
public class TilePaths
{
    [SerializeField] LayerMask solidLayer;
    [SerializeField] LayerMask grassLayer;

    public bool SolidPathTileChecker(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, Mathf.Epsilon, solidLayer))
        {
            return false;
        }
        return true;
    }

    //For now its like in classic pokemon games later i will revert to spawn system
    public void LongGrassPath(Vector3 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos, Mathf.Epsilon, grassLayer))
        {
            if (Random.Range(1, 101) <= 10)
                Debug.Log("Battle");
            //Encounter Battle;
        }
    }
}