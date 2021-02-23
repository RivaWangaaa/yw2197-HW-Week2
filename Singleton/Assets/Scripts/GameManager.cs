using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    int targetScore = 5;

    int currentLevel = 0;

    void Awake()
    {
        if (instance == null) 
        {
            DontDestroyOnLoad(gameObject);  
            instance = this; 
        }
        else  
        {
            Destroy(gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Score: " + score);
        if (score == targetScore)  //if the current score == the targetScore
        {
            currentLevel++; //increase the level number
            SceneManager.LoadScene(currentLevel); //go to the next level
            score = 0;
        }
    }
}
