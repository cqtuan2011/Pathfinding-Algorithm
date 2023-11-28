using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;

    private void Start()
    {
        //Resize(Camera.main.orthographicSize);
    }

    public void UpdateSizeAndPosition(float newCameraSize)
    {
        Resize(newCameraSize);
    }

    //Resize game object sprite scale to fit with camera size 
    private void Resize(float newCameraSize)
    {
        transform.localScale = new Vector3(1, 1, 1);

        float width = sprite.sprite.bounds.size.x;
        float height = sprite.sprite.bounds.size.y;

        float worldScreenHeight = newCameraSize * 2f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        var scaleFactorX = worldScreenWidth / width;
        var scaleFactorY = worldScreenHeight / height;
        var scaleFactor = Mathf.Max(scaleFactorX, scaleFactorY);

        gameObject.transform.localScale = new Vector3(scaleFactor, scaleFactor, 1) + Vector3.one * 0.1f;

        Vector3 centerWorldSpace = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, 0));
        this.transform.position = new Vector3(centerWorldSpace.x, centerWorldSpace.y);

    }
}
