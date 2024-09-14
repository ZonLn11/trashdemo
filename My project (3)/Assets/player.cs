using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    public Vector2 move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }
        transform.Translate(0, 0, Time.deltaTime*speed);

        if (Input.GetKey(KeyCode.A))
        {
            move.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move.x = 1;
        }
        else 
        {
            move.x = 0;
        }
        transform.Translate(move.x * Time.deltaTime * turnspeed, 0, 0);
        if (transform.position.x > 5 || transform.position.x < -5)
        { 
          transform.Translate(0, -Time.deltaTime * 10 , 0); 
        }
        if (transform.position.y < -10)
        {
            Time.timeScale = 0;
            GameObject.Find("GameOver").GetComponent<TextMesh>().text = "Game Over";
                }
    }
}
