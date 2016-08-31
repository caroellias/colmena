using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class VrMenu : MonoBehaviour
{

    //public GameObject Inicio;
    //public GameObject Exit;
    //public GameObject Test;

    public void StartCourse()
    {
        SceneManager.LoadScene("Excavator");
    }

    // Use this for initialization
    void Start()
    {
   
    //Inicio = GameObject.Find("Inicio").GetComponent<GameObject>();
      //  Exit = GameObject.Find("Exit").GetComponent<GameObject>();
        //Test = GameObject.Find("Test").GetComponent<GameObject>();
        UnityEngine.Cursor.visible = true;
    }





    // Update is called once per frame

    void Update()
    {

    }

}