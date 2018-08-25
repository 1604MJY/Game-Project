using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCtr : MonoBehaviour {
    public GameObject Eshow;
    public GameObject Talk;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Eshow.SetActive(true);
        }
    }
 
  
    private void OnTriggerExit2D(Collider2D collision)
   {
        if (collision.gameObject.tag == "Player")
        {
            Eshow.SetActive(false);
            Talk.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Talk.SetActive(true);
        }
    }
}
