using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacingDirection : MonoBehaviour
{
    private bool facingLeft = true;
    private float xScale;
    private float yScale;
    // Start is called before the first frame update
    void Start()
    {
        xScale = transform.localScale.x;
        yScale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0 && facingLeft)
        {
            facingLeft = false;
            transform.localScale = new Vector3(-xScale, yScale);
        }
        if (h < 0 && !facingLeft)
        {
            facingLeft = true;
            transform.localScale = new Vector3(xScale, yScale);
        }
        
    }
}
