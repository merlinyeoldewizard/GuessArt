using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

    public Camera mainCamera;
    public GameObject paintingZone;
    public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
    {
        mainCamera = Camera.main;
        float height = mainCamera.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;

        Sprite s = spriteRenderer.sprite;
        float unitWidth = s.textureRect.width / s.pixelsPerUnit;
        float unitHeight = s.textureRect.height / s.pixelsPerUnit;

        spriteRenderer.transform.localScale = new Vector3((width / unitWidth) * 0.9F, (height / unitHeight) * 0.85F);

        Vector3 origin = new Vector3(0, 0, 10);
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(origin);
        paintingZone.transform.position = worldPos;
    }
}
