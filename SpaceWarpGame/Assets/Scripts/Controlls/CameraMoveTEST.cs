using UnityEngine;
using System.Collections;

public class CameraMoveTEST : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        float SW = Input.GetAxis("Mouse ScrollWheel");

        if (SW >= 0.1f)
        {
           // print("Forward");

            Camera.main.orthographicSize--;
        }
        else if (SW <= -0.1f)
        {
            //print("Back");

            Camera.main.orthographicSize++;
        }


    }
}
