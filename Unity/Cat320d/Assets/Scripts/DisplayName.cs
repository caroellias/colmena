using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayName : MonoBehaviour {

    public Text myText;
    Color textColor;
    public float fadeTime;
    public Camera cameraToLookAt;
    // Use this for initialization
    void Start() {
        myText = GameObject.Find("Text").GetComponent<Text>();
        textColor = myText.color;
        myText.color = Color.clear;
    }

    public void showName()
    {
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        myText.transform.LookAt(cameraToLookAt.transform.position - v);
        myText.transform.Rotate(0, 180, 0);
        myText.color = Color.Lerp(myText.color, textColor, fadeTime * Time.deltaTime);
        Debug.Log("+SHOW NAME");
    }

    public void hideName()
    {
        myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        Debug.Log("-HIDE NAME");
    }

}
