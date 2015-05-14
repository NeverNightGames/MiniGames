using UnityEngine;
using System.Collections;

public class CameraMoveTEST : MonoBehaviour
{


    public float speed = 3f;

    public float sideSpeed = 3f;


    bool canZoomOut = true;

    bool canZoomIn = true;

    Vector3 currentCamPos;


    public int maxRight;

    public int maxLeft;

    public int maxUp;

    public int maxDown;
   
   

    // Use this for initialization
    void Start()
    {
        currentCamPos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y,this.gameObject.transform.position.z);

        
    }

    // Update is called once per frame
    void Update()
    {
        float SW = Input.GetAxis("Mouse ScrollWheel");

       // Vector2 mousPos = new Vector2();

        if (canZoomIn == true)
        {
            if (SW >= 0.1f)
            {
                //print("Forward");

                Camera.main.orthographicSize -= 3f;
            }
        }

        if (canZoomOut == true)
        {

            if (SW <= -0.1f)
            {
                //print("Back");

                Camera.main.orthographicSize += 3f;
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


            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * sideSpeed, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0f);

            // Camera.main.transform.Translate(mousPos);
        }
        else
        {
            this.gameObject.transform.position = currentCamPos;
        }




        if (this.gameObject.transform.position.x >= -maxRight)
        {
            //print("Stop");

            sideSpeed = 0;

            
        }
        else if (this.gameObject.transform.position.x <= -maxLeft)
        {
            sideSpeed = 0;

           
        }
        else
        {
            sideSpeed = 75;
        }
        
        if (this.gameObject.transform.position.y >= maxUp)
        {
            print("UP");

            speed = 0;
        }
        else if (this.gameObject.transform.position.y <= -maxDown)
        {
            print("DOWN");

            speed = 0;
        }
        else
        {
            speed = 75;
        }


    }
}
