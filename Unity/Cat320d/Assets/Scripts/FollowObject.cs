using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

    public GameObject targ = null;
    public bool orbitY = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(targ != null)
        {
            transform.LookAt(targ.transform);
            if (orbitY)
                transform.RotateAround(targ.transform.position, Vector3.up, Time.deltaTime * 15);
        }
	}
}
