using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{

    public GameObject CameraFocus;
    private Vector3 currentPosition;

	void Start ()
	{
	    currentPosition = transform.position;
	}
	
	void FixedUpdate ()
	{
	    transform.position = currentPosition - (currentPosition - Camera.main.ScreenToWorldPoint(Input.mousePosition))/8;

        currentPosition += (new Vector3(CameraFocus.transform.position.x - currentPosition.x, CameraFocus.transform.position.y - currentPosition.y, 0f)
            * Time.deltaTime * 10);
        //Debug.Log(currentPosition);
	}
}
