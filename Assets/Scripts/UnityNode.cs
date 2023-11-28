using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnityNode : MonoBehaviour
{
    public Bounds Bound { get { return this.spriteRenderer.bounds; } }
    public bool CanMove
    {
        get { return this.canMove; }
        set
        {
            UpdateStat(value);
            this.canMove = value;   
        }
    }


    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private TextMeshPro index;
    [SerializeField] private TextMeshPro cor;

    private bool canMove = true;

    public void Init(int index, Vector2 cor)
    {
        this.index.SetText(index.ToString());  
        this.cor.SetText($"({cor.x}, {cor.y})");
    }

    private void UpdateStat(bool value)
    {
        spriteRenderer.color = value ? Color.white : Color.red;
    }
}
