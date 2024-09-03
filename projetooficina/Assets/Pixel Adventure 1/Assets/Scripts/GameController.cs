using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

=======


public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText; 
>>>>>>> d49d32812d2d221fec48d53401e9b2889c449cd1

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText(){
        scoreText.text = totalScore.ToString();
    }
<<<<<<< HEAD

=======
>>>>>>> d49d32812d2d221fec48d53401e9b2889c449cd1
    
}
