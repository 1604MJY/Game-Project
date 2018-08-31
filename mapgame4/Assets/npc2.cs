using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc2 : MonoBehaviour {
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject Panel;
    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Talk1.SetActive(true);
            Panel.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Talk1.SetActive(false);
            Talk2.SetActive(true);
            Panel.SetActive(true);
        

        }
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.T))
        {
            Talk3.SetActive(true);
            Talk2.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Talk1.SetActive(false);
            Talk2.SetActive(false);
            Talk3.SetActive(false);
            Panel.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
