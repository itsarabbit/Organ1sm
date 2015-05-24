using System.Security.Policy;
using UnityEngine;
using System.Collections;

public class WorldGen : MonoBehaviour
{

    int BorderMarkerCount = 1;
    public GameObject BorderMarker;

	// Use this for initialization
	void Start ()
	{
	    BorderMarkerCount = (int)(GlobalVars.WorldRadius * 1.3f);
        CreateBorderMarkers();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreateBorderMarkers()
    {
        for (int i = 0; i < BorderMarkerCount; i++)
        {
            var o = Instantiate(BorderMarker, Vector3.zero, Quaternion.identity);
            ((GameObject)o).GetComponent<BorderMarkerBehaviour>().Time = Mathf.PI * 2 / BorderMarkerCount * i;
            ((GameObject) o).GetComponent<BorderMarkerBehaviour>().LengthOffset = 0.5f;
            Debug.Log("Created Border Marker nr. " + i);
        }

        for (int i = 0; i < BorderMarkerCount; i++)
        {
            var o = Instantiate(BorderMarker, Vector3.zero, Quaternion.identity);
            ((GameObject)o).GetComponent<BorderMarkerBehaviour>().Time = Mathf.PI * 2 / BorderMarkerCount * i + 0.33f;
            ((GameObject)o).GetComponent<BorderMarkerBehaviour>().LengthOffset = 2f;
            Debug.Log("Created Border Marker nr. " + i);
        }

        for (int i = 0; i < BorderMarkerCount; i++)
        {
            var o = Instantiate(BorderMarker, Vector3.zero, Quaternion.identity);
            ((GameObject)o).GetComponent<BorderMarkerBehaviour>().Time = Mathf.PI * 2 / BorderMarkerCount * i + 0.66f;
            ((GameObject)o).GetComponent<BorderMarkerBehaviour>().LengthOffset = 3f;
            Debug.Log("Created Border Marker nr. " + i);
        }
    }
}
