using System;
using UnityEngine;
using System.Collections;

public class BorderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var length = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2));
        if (length > GlobalVars.WorldRadius)
        {
            GetComponent<Rigidbody2D>().velocity += -(Vector2)transform.position.normalized * 100 *
                Math.Max(1, length - GlobalVars.WorldRadius) * Time.deltaTime;
        }
	}
}
