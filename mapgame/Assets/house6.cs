using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class house6 : MonoBehaviour {

    public GameObject OkBtn;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("scence1");
    }
  
    void Start () {
		
	}
	void Update () {
		
	}
}
