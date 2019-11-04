using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Paddle myPaddle; 

    //array declaration
    [SerializeField] AudioClip ballSounds;

    Vector2 paddleToBallDistance;

    bool hasStarated = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallDistance = this.transform.position - myPaddle.transform.position;
        
            
            //ball position -paddlePosition
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarated) //hasStarted == false
        {
            LockBallToPaddle();
            

            if(Input.GetMouseButtonDown (0)) //left click
            {
                hasStarated = true;
                //shoot the ball
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //generate random number
        int randomNumber = Random.Range(0,ballSounds.Length);
        //save random audio in clip
        AudioClip clip = ballSounds[randomNumber];
        //play the random clip
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = myPaddle.transform.position; 
        //set the Ball Position = Paddle Postion + paddleToBallPosition
        this.transform.position = paddlePosition + paddleToBallDistance;
    }
    
}
