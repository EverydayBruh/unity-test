using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZoneScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            logic.Win();
            collision.gameObject.GetComponent<Bear>().dead();
        }
    }
}
