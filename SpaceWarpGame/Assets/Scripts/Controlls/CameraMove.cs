using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{


    public float Upspeed = 3f;

    public float Downspeed = 3f;

    public float RsideSpeed = 3f;

    public float LsideSpeed = 3f;


    bool canZoomOut = true;

    bool canZoomIn = true;

    Vector3 currentCamPos;


    public int maxRight;

    public int maxLeft;

    public int maxUp;

    public int maxDown;

    bool canMoveBack;
   
   

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

                Camera.main.orthographicSize -= 5f;
            }
        }

        if (canZoomOut == true)
        {

            if (SW <= -0.1f)
            {
                //print("Back");

                Camera.main.orthographicSize += 5f;
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


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(RsideSpeed * Time.deltaTime,0,0);

            //print("D");
        }
     
     

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-LsideSpeed * Time.deltaTime, 0, 0);

            //print("D");
        }
     

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, Upspeed * Time.deltaTime, 0);

            //print("D");
        }
     


        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -Downspeed * Time.deltaTime, 0);

            //print("D");
        }
    
  



        if (this.gameObject.transform.position.x >= -maxRight)
        {
            //print("Stop");


            RsideSpeed = 0;
            
        }
        else if (this.gameObject.transform.position.x <= -maxLeft)
        {
            LsideSpeed = 0;
        }
        else
        {
            LsideSpeed = 75;

            RsideSpeed = 75;
        }
        
        if (this.gameObject.transform.position.y >= maxUp)
        {
           // print("UP");

            Upspeed = 0;
        }
        else if (this.gameObject.transform.position.y <= -maxDown)
        {
           // print("DOWN");

            Downspeed = 0;
        }
        else
        {
            Upspeed = 75;

            Downspeed = 75;
        }


    }
}
