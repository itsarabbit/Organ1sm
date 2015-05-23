using UnityEngine;
using System.Collections;

public class BorderMarkerBehaviour : MonoBehaviour
{

    public float Time;
    public float LengthOffset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Time += UnityEngine.Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(Time) * (GlobalVars.WorldRadius + LengthOffset) + Mathf.Sin(Time * 10) *0.1f,
            Mathf.Sin(Time) * (GlobalVars.WorldRadius + LengthOffset) + Mathf.Cos(Time * 10) * 0.25f, transform.position.z);
	}
}
