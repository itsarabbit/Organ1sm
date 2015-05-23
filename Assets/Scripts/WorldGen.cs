using System.Security.Policy;
using UnityEngine;
using System.Collections;

public class WorldGen : MonoBehaviour
{

    public int BorderMarkerCount;
    public GameObject BorderMarker;

	// Use this for initialization
	void Start () {
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
            Debug.Log("Created Border Marker");
        }
    }
}
