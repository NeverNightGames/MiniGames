using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurretTEST : MonoBehaviour
{

    //public float bulletSpeed;

    public GameObject bulletOBJ;

    public GameObject FirePos1;

    public GameObject FirePos2;

    public float shootTime;

    //public bool Fired;

    public float timer = 0f;


    private bool Clicked = false;

    private bool canFire;


    public bool canFireT1;

    public bool canFireT2;

    public Texture2D cursorTexture;
    public Texture2D cursorTexture1;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    //private MotherShipTest motherShip;

    private TotalResources totResource;


    // Use this for initialization
    void Start()
    {
       // motherShip = GameObject.Find("MotherShip").GetComponent<MotherShipTest>();

       totResource = GameObject.Find("Game Master").GetComponent<TotalResources>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Clicked == true)
        {
            // Look at
            Vector3 mousePosition = Input.mousePosition;

            mousePosition.z = 32;

            Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePosition);

            lookPos = lookPos - transform.position;

            float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //



            if (canFire == true)
            {
                Cursor.SetCursor(cursorTexture1, hotSpot, cursorMode);

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    //print("G");

                    if(canFireT1 == true)
                    {

                        if(totResource.totalAmmo >= 1)
                        {
                            timer += Time.fixedDeltaTime;

                            if (timer >= shootTime)
                            {
                                totResource.totalAmmo--;

                                Instantiate(bulletOBJ, FirePos1.transform.position, FirePos1.transform.rotation);

                                bulletOBJ.transform.LookAt(mousePosition);

                                //timer = 0;
                            }

                            
                        }

                    }

                    if (canFireT2 == true)
                    {
                        // if (timer >= shootTime)
                        // {
                        if (totResource.totalAmmo >= 1)
                        {

                            totResource.totalAmmo--;

                            //print("FIRING");

                            Instantiate(bulletOBJ, FirePos2.transform.position, FirePos2.transform.rotation);

                            bulletOBJ.transform.LookAt(mousePosition);
                        }

                        //timer = 0;
                        // }
                    }
                    //else if (motherShip.MSAmmo <= 0)
                    //{
                    //    motherShip.MSAmmo = 0;
                    //}

                }
            }
        }
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
            

    void OnMouseDown()
    {
        if (gameObject.transform.name == "MS Gun 1")
        {
            //print("CICKED");

            canFireT1 = true;
        }
        else if (gameObject.transform.name == "MS Gun 2")
        {
            canFireT2 = true;
        }

        if (Clicked == false)
        {
            //Cursor.SetCursor(cursorTexture1, hotSpot, cursorMode);

            canFire = true;

            Clicked = true;
        }
        else if (Clicked == true)
        {
            canFire = false;

            Cursor.SetCursor(null, Vector2.zero, cursorMode);

            Clicked = false;
        }
    }
}
