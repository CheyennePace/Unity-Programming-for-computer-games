using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Paddle myPaddle; 

    Vector2 paddleToBallDistance;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallDistance = this.transform.position - myPaddle.transform.position;
        
            
            //ball position -paddlePosition
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePosition = myPaddle.transform.position; 

        //set the Ball Position = Paddle Postion + paddleToBallPosition
        this.transform.position = paddlePosition + paddleToBallDistance;
    }
}
