using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class exit : MonoBehaviour {

    public GameObject OkBtn;
    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("scene1");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
