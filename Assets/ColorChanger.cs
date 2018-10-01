using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public TrailRenderer trailRend;
    public float speed = 50f;
    public float rotationspeed = 360f;

    void Start()
    {
        rend.color = color;
        //transform.position = new Vector3(-5, transform.position.y);
        //new Color(0, 1, 0);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green;
            trailRend.startColor = Color.black;
            trailRend.endColor = Color.yellow;
        }
    }
}
