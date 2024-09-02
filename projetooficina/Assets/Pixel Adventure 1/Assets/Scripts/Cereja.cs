using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cereja : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

<<<<<<< HEAD
    public GameObject collected; 
=======
    public GameObject collected;
>>>>>>> d49d32812d2d221fec48d53401e9b2889c449cd1
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

<<<<<<< HEAD
    

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();

            Destroy(gameObject, 0.3f);
        }
=======
   
    void OnTriggerEnter2D(Collider2D collider)
    {
            if(collider.gameObject.tag == "Player"){
                sr.enabled = false;
                circle.enabled = false;
                collected.SetActive(true);

                GameController.instance.totalScore += Score;
                GameController.instance.UpdateScoreText();
                Destroy(gameObject, 0.3f);
            }
>>>>>>> d49d32812d2d221fec48d53401e9b2889c449cd1
    }
}
