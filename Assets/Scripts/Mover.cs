using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    Transform tf;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.position -= tf.right;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.position += tf.right;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.position += tf.up;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.position -= tf.up;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position -= tf.right;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position += tf.right;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position += tf.up;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position -= tf.up;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            tf.position = new Vector2 (0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.P))
        {

        }






    }
}