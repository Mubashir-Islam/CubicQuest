using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGrid : MonoBehaviour
{
    public int GridRows;
    public int GridColumns;
    [Space]
    public Transform[] GridCubes;

    private void Awake()
    {
        GridCubes = new Transform[transform.childCount];

        for (int i = 0; i < GridCubes.Length; i++)
        {
            GridCubes[i] = transform.GetChild(i);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
