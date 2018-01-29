using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DrawingBoardButtons : MonoBehaviour {

    public Button DoneButton;
    public Button MenuButton;
    public Button ColourButton;
    public Button UndoButton;
    public PaintingTool paintingTool;
    
    public void Done()
    {

    }

    public void Menu()
    {

    }

    public void ChangeColour()
    {

    }

    public void Undo()
    {
        if (paintingTool.brushes.Count > 0)
        {
            int i = paintingTool.brushes.Count - 1;
            Destroy(paintingTool.brushes[i]);
            paintingTool.brushes.RemoveAt(i);
        }
    }
}
