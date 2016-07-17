using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighlightObject : MonoBehaviour {

    public GUISkin Gameskin;
    private Color startColor;
    private Color finishColor;
    private Shader shader;
    public Shader finishShader;
    public string objectName;
    private bool _displayObjectName = false;
    
    void OnGUI()
    {
        GUI.skin = Gameskin;
        DisplayName();
    }

    public void Highlight()
    {
        startColor = GetComponent<Renderer>().material.color;
        shader = GetComponent<Renderer>().material.shader;
        finishColor = Color.black;
        //finishColor.a = 0.9F;
        //
        if(finishShader == null)
        {
            //GetComponent<Renderer>().material.shader = Shader.Find("MK/MKGlow/Reflective/DiffuseBumpedNoLight");
            //GetComponent<Renderer>().material.shader = Shader.Find("MK/MKGlow/Unlit/Transparent");
            GetComponent<Renderer>().material.shader = Shader.Find("MK/MKGlow/Mobile/Diffuse");
        }
        else
        {
            GetComponent<Renderer>().material.shader = finishShader;
        }
        //GetComponent<Renderer>().material.shader = Shader.Find("MK/MKGlow/Normal/Glossy");
        GetComponent<Renderer>().material.color = finishColor;

        _displayObjectName = true;
    }

    public void deHighlight()
    {
        GetComponent<Renderer>().material.shader = shader;
        GetComponent<Renderer>().material.color = startColor;
        _displayObjectName = false;
    }

    public void DisplayName()
    {
        if (_displayObjectName)
        {
            //GUI.Box(new Rect(Screen.width/3 - 155, Screen.height - 100, 200, 70), objectName, customGuiStyle);
            GUI.Box(getRightRect(), objectName);
            GUI.Box(getLeftRect(), objectName);
        }
    }

	// Use this for initialization
	void Start () {
        InitGameskin();
	}
	
    void InitGameskin()
    {
        if (Gameskin != null)
        {
            Gameskin.box.alignment = TextAnchor.MiddleCenter;
            Gameskin.box.wordWrap = true;

            double width = Screen.width;
            double height = Screen.height;

            //The font size is calculated by dividing the screen by 2 and dividing by K (Tested Constant) to get a perfect size
            //int fontK = 30;
            double fontK = 0.017;
            //Gameskin.box.fontSize = (int) (width / 2) / fontK;
            Gameskin.box.fontSize = (int) (width * fontK);
            //Gameskin.box.fontSize = 40;
            //Debug.Log("Gameskin.box.fontSize: " + Gameskin.box.fontSize);

            //Debug.Log("width: " + width);
            //Debug.Log("height: " + height);

        }
    }

    private Rect getLeftRect()
    {
        //Percentages to get the perfect rectangle depending on the screen size
        float widthPercentage = 0.1465F;
        float heightPercentage = 0.1232F;

        float rectWidth = Screen.width * widthPercentage;
        float rectHeight = Screen.height * heightPercentage;

        float posX = ((Screen.width / 2) / 2) - (rectWidth / 2);
        float posY = Screen.height * 0.8F;
        //Debug.Log("posXLeft: " + posX);
        return new Rect(posX, posY, rectWidth, rectHeight);
    }

    private Rect getRightRect()
    {
        //Percentages to get the perfect rectangle depending on the screen size
        float widthPercentage = 0.1465F;
        float heightPercentage = 0.1232F;

        float rectWidth = Screen.width * widthPercentage;
        float rectHeight = Screen.height * heightPercentage;

        //float posX = (Screen.width * 0.77F) - rectWidth;
        float posX = ((Screen.width / 2) / 2) + (Screen.width / 2) - (rectWidth / 2);
        float posY = Screen.height * 0.8F;

        //Debug.Log("posXRight: " + posX);
        return new Rect(posX, posY, rectWidth, rectHeight);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
