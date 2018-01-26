using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebRaycast : MonoBehaviour
{
    public List<GameObject> webs;
    public GameObject webNode;
    public GameObject cameraMain;
	
	void Start ()
    {
        webs = new List<GameObject>();
	}
	
	void Update ()
    {
        if (webs.Count > 1)
        {
            for (int i = 0; i < webs.Count; i++)
            {
                if (i > 0)
                {
                    Physics.Raycast(webs[i - 1].transform.position, (webs[i-1].transform.position - webs[i].transform.position));
                    Debug.DrawRay(webs[i].transform.position, (webs[i-1].transform.position - webs[i].transform.position), Color.red);
                }           
            }
        }

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(cameraMain.transform.position,ray.direction, out hit))
            {
                if (hit.transform.tag != "WebJoint")
                {
                    webs.Add(Instantiate(webNode, hit.point, Quaternion.identity));
                }          
            }
        }
	}
}
