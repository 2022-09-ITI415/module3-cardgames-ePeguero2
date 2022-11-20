using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardPyramidSolitaire : Card
{
    [Header("Set Dynamically: CardProspector")]
 public CardState state = CardState.drawpile;
 public List<CardProspector> hiddenBy = new List<CardProspector>();
 public int layoutID;
 public SlotDef slotDef;
}

