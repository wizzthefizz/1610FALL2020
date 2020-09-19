using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float x, y, z;
    public int score = 100;

    public float health;

    public string password = "password";

    public string playerName = "Emege";
    public float moveSpeed;

    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Hello World!");
        
    }

    // Update is called once per frame
    void Update()
    {
        var vInput = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        var hInput = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        var z = 0;
        transform.Translate(hInput, vInput,0);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }

    public void Down()
    {
        transform.Translate(0,-speed,0);
    }
    
}
