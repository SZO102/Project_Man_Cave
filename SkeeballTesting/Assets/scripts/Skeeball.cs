using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeeball : MonoBehaviour

    
{
    // Start is called before the first frame updat
    public int score = 0;
    public int tries = 3;
    public GameObject ball;
    public Vector3 initialposition;
    void Start()
    {
        initialposition = transform.position;//ball's position when placed in unity is where the ball will respawn from, if you place it in a container, it will spawn at the container
        
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)// on collision ball should instantiate then destroy itself
    {
        if (collision.collider.tag == "MiddleRing")// on collision with middle goal adds score.
        {
            collision.gameObject.GetComponent<Gamemanager>().score += 50;// sends score to skeeball manager, 50 because the middle ring is stationary

            GameObject instance = Instantiate(ball, initialposition, transform.rotation);// spawns new ball at original position.
            Destroy(this.gameObject);// destroys ball
        }
        if (collision.collider.tag == "InnerRing")// the second ring next to the middle ring
        {
            collision.gameObject.GetComponent<Gamemanager>().score += 250;// score is flexible.

            GameObject instance = Instantiate(ball, initialposition, transform.rotation);// spawns new ball at original position.
            Destroy(this.gameObject);// destroys ball
        }
        if (collision.collider.tag == "OuterRing")//The outer ring
        {
            collision.gameObject.GetComponent<Gamemanager>().score += 500;// should be fairly high since the outer ring is wider.

            GameObject instance = Instantiate(ball, initialposition, transform.rotation);// spawns new ball at original position.
            Destroy(this.gameObject);// destroys ball
        }
        if (collision.collider.tag == "RingOut")// can be named miss or something more creative.
        {
            collision.gameObject.GetComponent<Gamemanager>().tries -= 1;// reduces the number of times the player can attempt skeeball.

            GameObject instance = Instantiate(ball, initialposition, transform.rotation);// spawns new ball at original position.
            Destroy(this.gameObject);// destroys ball
            
        }
    }




}
