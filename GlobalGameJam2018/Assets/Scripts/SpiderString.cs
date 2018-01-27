using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderString : MonoBehaviour {

    //VARIABLES
    private Vector3 fromJoint; //Starting point of the string
    private Vector3 toJoint; //Ending point of the string

    //GET METHODS
    public Vector3 FromJoint
    {
        get
        {
            return fromJoint;
        }
    }

    public Vector3 ToJoint
    {
        get
        {
            return toJoint;
        }
    }

    //CONSTRUCTOR METHOD
    public SpiderString(GameObject from, GameObject to)
    {
        fromJoint = from.transform.position;
        toJoint = to.transform.position;
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
