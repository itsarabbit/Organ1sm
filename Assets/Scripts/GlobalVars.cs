using System;
using System.Security.Policy;
using System.Timers;
using UnityEngine;
using System.Collections;

public class GlobalVars : MonoBehaviour
{
    public static float WorldRadius = 10;
    private float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        //Varies the world radius
	    //WorldRadius += Time.deltaTime*Mathf.Sin(Time.time * 20) * 9;
	}
}
