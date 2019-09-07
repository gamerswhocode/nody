using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenResizer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = spriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        float width = sprite.bounds.size.x;
        float height = sprite.bounds.size.y;

        float worldScreenHeight = (float)(Camera.main.orthographicSize * 2.0);
        float worldScreenWidth = (float)(worldScreenHeight / Screen.height * Screen.width);

        Vector2 sizeX = new Vector2(worldScreenWidth / width, transform.localScale.y);
        transform.localScale = sizeX;

        Vector2 sizeY = new Vector2(transform.localScale.x, worldScreenHeight / height);
        transform.localScale = sizeY;
    }
}
