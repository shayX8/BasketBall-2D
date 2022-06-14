using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallForce : MonoBehaviour
{
    Rigidbody2D basketBallForce;
    float startXPosition, startYPosition, xPosition, yPosition;

    // Start is called before the first frame update
    void Start()
    {
        startXPosition = transform.position.x;
        startYPosition = transform.position.y;
        

        basketBallForce = GetComponent<Rigidbody2D>();
        basketBallForce.AddForce(new Vector2(-100, 400));
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        if (xPosition <8.3f && xPosition > 6.4f && yPosition > -0.2f && yPosition < 0)
        {
            //freez ball on the basket
            //basketBallForce.velocity = new Vector2(0, 0);

            ScoreText.scoreValue++;

            //refresh game after score 
            transform.position = new Vector2(startXPosition, startYPosition);
            basketBallForce.AddForce(new Vector2(-100, 400));

            //retorn player to start position
            PlayerMovement.ResetLocation();
            
        }
    }
}
