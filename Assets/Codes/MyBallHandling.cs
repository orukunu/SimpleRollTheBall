using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyBallHandling : MonoBehaviour
{
    Rigidbody physics;
    public int speed;
    int score = 0;
    public int collectionSize;
    public Text scoreText;
    public Text timeText;
    public Text gameOverText;
    float totalTime = Time.fixedTime;


    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalRaw = Input.GetAxisRaw("Horizontal");
        float verticalRaw = Input.GetAxisRaw("Vertical");
        timeText.text = "TIME :" + Time.fixedTime;

        Vector3 velocityVector = new Vector3(horizontalRaw,0,verticalRaw);

        physics.AddForce(velocityVector*speed);
    }

    void OnTriggerEnter(Collider obsticale)
    {
        if (obsticale.gameObject.tag == "Obsticale")
        {
            obsticale.gameObject.SetActive(false);
            score++;
            scoreText.text = "SCORE = " + score;

            if ( score == collectionSize)
            {
                gameOverText.gameObject.SetActive(true);
            }
        }
    }
}
