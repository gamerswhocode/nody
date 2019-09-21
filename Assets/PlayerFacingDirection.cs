using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacingDirection : MonoBehaviour
{
    private const string HORIZONTAL_AXIS = "Horizontal";

    private Vector2 scale;
    private bool wasFacingLeft;

    // Start is called before the first frame update
    void Start()
    {
        scale.x = transform.localScale.x;
        scale.y = transform.localScale.y;
        wasFacingLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        float playerHorizontalAxisValue = Input.GetAxis(HORIZONTAL_AXIS);
        if (playerHorizontalAxisValue == 0)
        {
            return;
        }

        Func<bool> isCurrentlyFacingRight = () => playerHorizontalAxisValue > 0;
        Func<bool> shouldCharacterFaceRight = () => isCurrentlyFacingRight() && wasFacingLeft;
        Func<bool> shouldCharacterFaceLeft = () => !isCurrentlyFacingRight() && !wasFacingLeft;

        if (shouldCharacterFaceRight())
        {
            wasFacingLeft = false;
            transform.localScale = new Vector3(-scale.x, scale.y);
        }
        else if (shouldCharacterFaceLeft())
        {
            wasFacingLeft = true;
            transform.localScale = new Vector3(scale.x, scale.y);
        }

    }
}
