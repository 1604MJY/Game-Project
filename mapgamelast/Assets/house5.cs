using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class house5 : MonoBehaviour {

    public GameObject OkBtn;
    // Use this for initialization
    
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Scene");
    }
    void Start () {
		
	}
  
    void Update () {
		
	}
}
