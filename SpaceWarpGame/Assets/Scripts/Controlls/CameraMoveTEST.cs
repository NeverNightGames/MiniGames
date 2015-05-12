using UnityEngine;
using System.Collections;

public class CameraMoveTEST : MonoBehaviour
{

    public bool canZoomOut = true;

    public bool canZoomIn = true;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float SW = Input.GetAxis("Mouse ScrollWheel");

        Vector2 mousPos = new Vector2();

        if (canZoomIn == true)
        {
            if (SW >= 0.1f)
            {
                //print("Forward");

                Camera.main.orthographicSize--;
            }
        }

        if (canZoomOut == true)
        {

            if (SW <= -0.1f)
            {
                //print("Back");

                Camera.main.orthographicSize++;
            }
        }

        if (Camera.main.orthographicSize >= 82.5)
        {
            canZoomOut = false;

        }
        else
        {
            canZoomOut = true;
        }

        if (Camera.main.orthographicSize <= 25.5)
        {
            canZoomIn = false;
        }
        else
        {
            canZoomIn = true;
        }


        if (Input.GetMouseButton(1))
        {
            //print("PRESS");

            float speed = 3f;
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);

           // Camera.main.transform.Translate(mousPos);
        }


    }
}
