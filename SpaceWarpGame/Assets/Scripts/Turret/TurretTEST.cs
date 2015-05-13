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


    private MotherShipTest motherShip;

  //  private TotalResources totResource;


    // Use this for initialization
    void Start()
    {
        motherShip = GameObject.Find("MotherShip").GetComponent<MotherShipTest>();

       // totResource = GameObject.Find("Game Master").GetComponent<TotalResources>();

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

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    //print("G");

                    if(canFireT1 == true)
                    {

                        if (motherShip.MSAmmo >= 1)
                        {
                            timer += Time.fixedDeltaTime;

                            if (timer >= shootTime)
                            {
                                motherShip.MSAmmo--;

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
                        if (motherShip.MSAmmo >= 1)
                        {

                            motherShip.MSAmmo--;

                            print("FIRING");


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
            canFire = true;

            Clicked = true;
        }
        else if (Clicked == true)
        {
            canFire = false;

            Clicked = false;
        }
    }
}
