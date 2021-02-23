using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public static Monster instance;
    private float timer = 0;
    
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
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            transform.position = new Vector2( //teleport to a random location
                Random.Range(-5,5),
                Random.Range(-5,5));

            timer = 0;
            GameManager.instance.score++;
            
        }

        print(timer);
    }



    private void OnCollisionEnter2D(Collision2D other)
    {

        print("End");
        SceneManager.LoadScene("EndScene");
    }
}
