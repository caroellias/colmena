using UnityEngine;
using System.Collections;

public class MovePiston : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * (Time.deltaTime * 10));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * (Time.deltaTime * 10));
        }
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
