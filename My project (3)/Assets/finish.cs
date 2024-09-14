using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Text").gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Text").gameObject.SetActive(true);
    }
}
