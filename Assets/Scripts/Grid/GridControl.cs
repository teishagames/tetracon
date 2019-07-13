using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridControl : MonoBehaviour
{
    private int rows = 10;
    private int cols = 6;
    private float tileSize = 0.90f;
   
    [SerializeField] GameObject button;


    private void Start()
    {
        GenerateGrid();
       
       
    }
   private void GenerateGrid() {
        
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                GameObject _button = Instantiate(button,transform) as GameObject;
                float posX = col * tileSize;
                float posY = row * -tileSize;

                _button.transform.position = new Vector2(posX, posY);
            }
        }
        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);
    }
}
