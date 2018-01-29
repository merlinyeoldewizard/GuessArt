using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PaintingTool : MonoBehaviour {

    public BoxCollider paintingZone;
    public GameObject brush;
    public Material paintBrushColour;
    private GameObject newBrush;
    public bool paintingTurn;
    public List<GameObject> brushes = new List<GameObject>();

    public void Update()
    {
        if (paintingTurn)
        {
            RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 brushPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 9.0F));        

                if (Input.GetMouseButtonDown(0) && paintingZone.Raycast(ray, out hit, 15.0F))
                {
                    newBrush = Instantiate(brush, brushPosition, transform.rotation);
                    newBrush.GetComponent<Renderer>().material.color = Color.black;
                    brushes.Add(newBrush);
                }
                if (Input.GetMouseButton(0) && paintingZone.Raycast(ray, out hit, 15.0F))
                {
                    newBrush.transform.position = brushPosition;
                }
                else if (Input.GetMouseButton(0) && paintingZone.Raycast(ray, out hit, 15.0F))
                {
                    newBrush.transform.position = brushPosition;
                }

                if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
                    newBrush = null;
        }
        
    }

}
