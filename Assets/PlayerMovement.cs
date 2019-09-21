using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICAL_AXIS = "Vertical";

    public Transform playerTransform;
    [Range(0,0.5f)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerHorizontalAxisValue = Input.GetAxis(HORIZONTAL_AXIS);
        float playerVerticalAxisValue = Input.GetAxis(VERTICAL_AXIS);

        const float zDepth = 0.0f;
        Vector3 newMovementPosition = new Vector3(playerHorizontalAxisValue * speed, playerVerticalAxisValue * speed, zDepth);

        playerTransform.position += newMovementPosition;
    }
}
