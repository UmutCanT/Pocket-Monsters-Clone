using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move 
{
    MoveTemplate moveTemplate;
    int currentPP;

    public Move(MoveTemplate moveTemplate)
    {
        this.moveTemplate = moveTemplate;
        currentPP = moveTemplate.PowerPoint;
    }
}
