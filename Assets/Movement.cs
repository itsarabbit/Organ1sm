using System;
using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public KeyCode Right, Left, Up, Down;
    public float Speed;
    Rigidbody2D rigidbody;

	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if (Input.GetKey(Right))
        {
            rigidbody.velocity += new Vector2(Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(Left))
        {
            rigidbody.velocity += new Vector2(-Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(Up))
        {
            rigidbody.velocity += new Vector2(0, Speed * Time.deltaTime);
        }
        if (Input.GetKey(Down))
        {
            rigidbody.velocity += new Vector2(0, -Speed * Time.deltaTime);
        }
	    var screenPosition = Camera.main.WorldToScreenPoint(transform.localPosition);
	    var offset = new Vector2(Input.mousePosition.x - screenPosition.x, Input.mousePosition.y - screenPosition.y);
	    var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        transform.localRotation = Quaternion.Euler(0, 0, angle);
        //stransform.rotation = Quaternion.FromToRotation(transform.localPosition, Input.);
	    //transform.TransformDirection(transform.position.x - Input.mousePosition.x, transform.position.y - Input.mousePosition.y, 0);
    }

    void FixedUpdate()
    {

    }
}
