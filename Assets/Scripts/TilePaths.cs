using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class TilePaths
{
    [SerializeField] LayerMask solidLayer;

    public bool SolidPathTileChecker(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, Mathf.Epsilon, solidLayer))
        {
            return false;
        }
        return true;
    }
}