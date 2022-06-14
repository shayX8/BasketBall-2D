using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float  dirHor, dirVer, dirMouseX, dirMouseY;
    static float startXPosition, startYPosition, xPosition, yPosition;
    static Transform reLocationTransform;

    // Start is called before the first frame update
    void Start()
    {
        reLocationTransform = GetComponent<Transform>();
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        startXPosition = transform.position.x;
        startYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //keybord movment
        dirHor = Input.GetAxisRaw("Horizontal");
        dirVer = Input.GetAxisRaw("Vertical");

        //left and right
        xPosition = xPosition + (dirHor / 10 * Time.deltaTime);

        //up and dowe
        yPosition = yPosition + (dirVer / 20 * Time.deltaTime);


        //mouse movment 
        dirMouseX = Input.GetAxis("Mouse X");
        dirMouseY = Input.GetAxis("Mouse Y");

        //left and right
        xPosition = xPosition + (dirMouseX);

        //up and dowe
        yPosition = yPosition + (dirMouseY);

        //the player dont go out of the borders
        if (xPosition > 8.1f)
        {
            xPosition = 8.1f;
        }
        else if (xPosition < -8.1f)
            xPosition = -8.1f;

        if (yPosition > 4.2f)
        {
            yPosition = 4.2f;
        }
        else if (yPosition < -4.2f)
            yPosition = -4.2f;

        transform.position = new Vector2(xPosition, yPosition);
    }

    //retorn player to start position
    public static void ResetLocation()
    {
        reLocationTransform.transform.position = new Vector2(startXPosition, startYPosition);
        xPosition = startXPosition;
        yPosition = startYPosition;

    }
}
