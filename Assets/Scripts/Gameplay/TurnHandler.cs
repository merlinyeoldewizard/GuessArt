using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHandler : MonoBehaviour {
    

    //Enable/Disable ability to interact with inout field and painting zone.
    //Alternate which is interactable.
    //Keep what's been drawn/written to allow players to review the game.

    public void NextTurn(bool isDrawingTurn)
    {
        MoveCameraToNextBoard();
        switch (isDrawingTurn)
        {
            case true:
                DrawingTurn();
                break;
            case false:
                WritingTurn();
                break;
        }
    }

    public void MoveCameraToNextBoard()
    {

    }

    public void DrawingTurn()
    {

    }

    public void WritingTurn()
    {

    }
    
}
