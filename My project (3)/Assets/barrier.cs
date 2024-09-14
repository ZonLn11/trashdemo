using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
   
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "腰子给我创掉了");
        if (other.name == "Player")
        { 
            Time.timeScale = 0;
        }
        
    }
  
    
}
