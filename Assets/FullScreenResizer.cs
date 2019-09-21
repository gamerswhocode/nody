using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenResizer : MonoBehaviour
{    
    private Sprite sprite;

    public SpriteRenderer SpriteToRender;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = SpriteToRender.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spriteSize = sprite.bounds.size;        
        float width = spriteSize.x;
        float height = spriteSize.y;

        const float screenDoubleSize = 2.0f;

        float worldScreenHeight = Camera.main.orthographicSize * screenDoubleSize;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        //Vector2 sizeX = new Vector2(worldScreenWidth / width, transform.localScale.y);
        //transform.localScale = sizeX;

        //Vector2 sizeY = new Vector2(transform.localScale.x, worldScreenHeight / height);
        //transform.localScale = sizeY;
    }
}
