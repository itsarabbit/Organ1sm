using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class BorderMarkerBehaviour : MonoBehaviour
{

    public float Time;
    public float LengthOffset;
    private float lengthOffsetTimeMultiplier = 1;

	// Use this for initialization
	void Start ()
	{
	    lengthOffsetTimeMultiplier = Random.Range(0.5f, 1.8f);
	}
	
	// Update is called once per frame
	void Update ()
	{
        Time += UnityEngine.Time.deltaTime / GlobalVars.WorldRadius * 10;
	    float LengthOffsetTemp = Mathf.Abs(Mathf.Sin(lengthOffsetTimeMultiplier*Time*6)) + 0.5f;
        transform.position = new Vector3(Mathf.Cos(Time) * (GlobalVars.WorldRadius + LengthOffsetTemp),
            Mathf.Sin(Time) * (GlobalVars.WorldRadius + LengthOffsetTemp), transform.position.z);
	}
}
