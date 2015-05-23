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

        transform.rotation.SetFromToRotation(new Vector2(transform.position.x, transform.position.y), Input.mousePosition);
    }

    void FixedUpdate()
    {

    }
}
