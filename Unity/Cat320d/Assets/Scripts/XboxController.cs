using UnityEngine;
using System.Collections;

public class XboxController : MonoBehaviour {

    public string part = "";
    public string axis = "";
    public bool isButton = false;
    public float maxAng = 0;
    public float minAng = 0;
    private Rigidbody rb;
    public bool forward = true;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown(Xbox360ControllerMap.BUTTON_B))
        {
            forward = !forward;
        }
        if (isButton)
        {
            
        }else
        {
            Vector3 inputDirection = Vector3.zero;
            if (axis.Equals(AxisXbox360.JOY_LEFT))
            {
                inputDirection.x = Input.GetAxis(Xbox360ControllerMap.JOY_LEFT_HORIZONTAL);
                inputDirection.z = Input.GetAxis(Xbox360ControllerMap.JOY_LEFT_VERTICAL);
            }
            else if(axis.Equals(AxisXbox360.JOY_RIGHT))
            {
                inputDirection.x = Input.GetAxis(Xbox360ControllerMap.JOY_RIGHT_HORIZONTAL);
                inputDirection.z = Input.GetAxis(Xbox360ControllerMap.JOY_RIGHT_VERTICAL);
            }
            else if (axis.Equals(AxisXbox360.TRIGGER))
            {
                inputDirection.x = Input.GetAxis(Xbox360ControllerMap.TRIGGER_LEFT);
                inputDirection.z = Input.GetAxis(Xbox360ControllerMap.TRIGGER_RIGHT);
            }
            movePart(inputDirection);
        }
    }

    void movePart(Vector3 inputDirection)
    {
        float velocity = 1;
        Vector3 rotation = Vector3.zero;
        bool isRotable = false;

        if (part.Equals(Cat320Part.CUCHARA))
        {
            velocity = calculateVelocity(inputDirection.x);
            rotation = inputDirection.x * Time.deltaTime * Vector3.right * velocity;
            isRotable = canRotate(transform.localEulerAngles.x, rotation.x);
        }
        else if (part.Equals(Cat320Part.PLUMA))
        {
            velocity = calculateVelocity(inputDirection.z);
            rotation = inputDirection.z * Time.deltaTime * Vector3.right * velocity;
            isRotable = canRotate(transform.localEulerAngles.x, rotation.x);
        }
        else if (part.Equals(Cat320Part.BRAZO))
        {
            velocity = calculateVelocity(inputDirection.z);
            rotation = inputDirection.z * Time.deltaTime * Vector3.right * velocity;
            isRotable = canRotate(transform.localEulerAngles.x, rotation.x);
        }
        else if (part.Equals(Cat320Part.CUERPO))
        {
            velocity = calculateVelocity(inputDirection.x);
            rotation = inputDirection.x * Time.deltaTime * Vector3.up * velocity;
            isRotable = true;
        }
        else if (part.Equals(Cat320Part.ALL))
        {

        }
        else if (part.Equals(Cat320Part.CADENAS))
        {
            //Debug.Log("trigger left: " + inputDirection.x + "  -  trigger right: " + inputDirection.z);
            Vector3 movement = Vector3.zero;
            Vector3 rot = Vector3.zero;
            if (forward)
            {
                movement = new Vector3(0.0f, 0.0f, -Mathf.Abs(inputDirection.z));
            }else
            {
                movement = new Vector3(0.0f, 0.0f, Mathf.Abs(inputDirection.z));
            }
            transform.Translate(movement);
            float vel = 0.0f;
            if (inputDirection.x < 0)
            {
                vel = calculateRotation(inputDirection.x);               
                rot = new Vector3(0.0f, vel, 0.0f);
            }else
            {
                vel = calculateRotation(inputDirection.z);                
                rot = new Vector3(0.0f, vel, 0.0f);
            }
            transform.Rotate(rot);
        }
        else if (part.Equals(Cat320Part.CADENA_DERECHA))
        {

        }
        else if (part.Equals(Cat320Part.CADENA_IZQUIERDA))
        {

        }
        else
        {

        }

        if( (part.Equals(Cat320Part.CUCHARA) || part.Equals(Cat320Part.PLUMA) || part.Equals(Cat320Part.BRAZO) || part.Equals(Cat320Part.CUERPO) ) && isRotable)
        {
            transform.Rotate(rotation);
        }

    }
    
    bool canRotate(float localEulerAngle, float rotation)
    {
        float newAngle = localEulerAngle + rotation;
        newAngle = (newAngle > 180) ? newAngle - 360 : newAngle;
        return (newAngle < maxAng) && (newAngle > minAng);        
    }

    float calculateVelocity(float axisValue)
    {
        float velocity = 0;
        float absAxisValue = Mathf.Abs(axisValue);
        
        if(absAxisValue >= 0.2f && absAxisValue < 0.3f)
        {
            velocity = 5;
        }else if (absAxisValue >= 0.3f && absAxisValue < 0.4f)
        {
            velocity = 10;
        }
        else if (absAxisValue >= 0.4f && absAxisValue < 0.5f)
        {
            velocity = 17;
        }
        else if (absAxisValue >= 0.5f && absAxisValue < 0.6f)
        {
            velocity = 25;
        }
        else if (absAxisValue >= 0.6f && absAxisValue < 0.7f)
        {
            velocity = 36;
        }
        else if (absAxisValue >= 0.7f && absAxisValue < 0.8f)
        {
            velocity = 48;
        }
        else if (absAxisValue >= 0.8f && absAxisValue < 0.9f)
        {
            velocity = 60;
        }
        else if (absAxisValue >= 0.9f && absAxisValue <= 1f)
        {
            velocity = 75;
        }

        return velocity;
    }

    float calculateRotation(float axisValue)
    {
        float velocity = 0;
        float absAxisValue = Mathf.Abs(axisValue);

        if (absAxisValue >= 0.2f && absAxisValue < 0.3f)
        {
            velocity = 1;
        }
        else if (absAxisValue >= 0.3f && absAxisValue < 0.4f)
        {
            velocity = 2;
        }
        else if (absAxisValue >= 0.4f && absAxisValue < 0.5f)
        {
            velocity = 3;
        }
        else if (absAxisValue >= 0.5f && absAxisValue < 0.6f)
        {
            velocity = 4;
        }
        else if (absAxisValue >= 0.6f && absAxisValue < 0.7f)
        {
            velocity = 5;
        }
        else if (absAxisValue >= 0.7f && absAxisValue < 0.8f)
        {
            velocity = 8;
        }
        else if (absAxisValue >= 0.8f && absAxisValue < 0.9f)
        {
            velocity = 12;
        }
        else if (absAxisValue >= 0.9f && absAxisValue <= 1f)
        {
            velocity = 20;
        }

        if (axisValue < 0)
            velocity = -velocity;

        return velocity;
    }

}

static class Xbox360ControllerMap
{
    public static string JOY_LEFT_HORIZONTAL { get { return "xLJoyHor"; } }
    public static string JOY_LEFT_VERTICAL { get { return "xLJoyVer"; } }
    public static string JOY_RIGHT_HORIZONTAL { get { return "xRJoyHor"; } }
    public static string JOY_RIGHT_VERTICAL { get { return "xRJoyVer"; } }
    public static string TRIGGER_LEFT { get { return "xLTJoy"; } }
    public static string TRIGGER_RIGHT { get { return "xRTJoy"; } }
    public static string BUTTON_A { get { return "xAbutton"; } }
    public static string BUTTON_B { get { return "xBbutton"; } }
    public static string BUTTON_X { get { return "xXbutton"; } }
    public static string BUTTON_Y { get { return "xYbutton"; } }
    public static string BUMPER_LEFT { get { return "xLBbutton"; } }
    public static string BUMPER_RIGHT { get { return "xRBbutton"; } }
    public static string BUTTON_BACK { get { return "xBackbutton"; } }
    public static string BUTTON_START { get { return "xStartbutton"; } }
    public static string JOY_LEFT_BUTTON { get { return "xLJoybutton"; } }
    public static string JOY_RIGHT_BUTTON { get { return "xRJoybutton"; } }
}

static class Cat320Part
{
    public static string ALL { get { return "all"; } }
    public static string CUCHARA { get { return "cuchara"; } }
    public static string PLUMA { get { return "pluma"; } }
    public static string BRAZO { get { return "brazo"; } }
    public static string CUERPO { get { return "cuerpo"; } }
    public static string CADENA_DERECHA { get { return "cadena_derecha"; } }
    public static string CADENA_IZQUIERDA { get { return "cadena_izquierda"; } }
    public static string CADENAS { get { return "cadenas"; } }
}

static class AxisXbox360
{
    public static string TRIGGER { get { return "trigger"; } }
    public static string JOY_LEFT { get { return "left"; } }
    public static string JOY_RIGHT { get { return "right"; } }    
}