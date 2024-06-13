using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Generator : MonoBehaviour
{

    public GameObject gridObject;
    public int rows = 10;
    public int columns = 10;
    public int rowsPerColumn = 10;
    public int columnsPerRow = 10;
    public int spacing = 2;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Vector3 position = new Vector3(i*spacing,0,j*spacing);
                Instantiate(gridObject,position,Quaternion.identity);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
