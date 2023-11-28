using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridRenderer : MonoBehaviour
{
    [SerializeField] private TMP_InputField rowInput;
    [SerializeField] private TMP_InputField columnInput;

    [SerializeField] private UnityNode nodePrefab;

    int row, column;

    [ContextMenu("Generate Grid Visual")]
    public void GenerateGridVisual()
    {
        int count = 0;

        Int32.TryParse(rowInput.text, out row);
        Int32.TryParse(columnInput.text, out column);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                var node = Instantiate(nodePrefab, this.transform);
                Vector2 pos = new Vector2((float)i, (float)j);
                node.transform.localPosition = pos;
                node.Init(count, pos);

                count++;
            }   
        }
    }

}
