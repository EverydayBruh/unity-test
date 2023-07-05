using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class russiaMoveScript : MonoBehaviour
{

    public float speed = 10;
    public float speedCurve = 10;
    public float deadzone = -12;
    private GameObject player;
    private float curspeed;
    private int sign;
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        curspeed = speed - (curve.Evaluate(player.transform.position.x/10+1/2))* (curve.Evaluate(player.transform.position.x / 10 + 1 / 2)) * speedCurve;
        Debug.Log(curspeed.ToString());
        transform.position = transform.position + (Vector3.left * curspeed) * Time.deltaTime / 10;
        if(transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
