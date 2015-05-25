using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Turret : MonoBehaviour
{

    //public float bulletSpeed;

    public GameObject bulletOBJ;

    public GameObject FirePos1;

    public GameObject FirePos2;

    public float shootTime;

    //public bool Fired;

    public float timer = 0f;


    private bool Clicked = false;

    public bool canFire;


    public bool canFireT1;

    public bool canFireT2;

    public Texture2D cursorTexture;
    public Texture2D cursorTexture1;

    public AudioClip ShootSFX;

    AudioSource AS;

    // public Button turretButton;

    CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotSpot = Vector2.zero;


    private MotherShip motherShip;

    private TotalResources totResource;


    // Use this for initialization
    void Start()
    {
        motherShip = GameObject.Find("MotherShip").GetComponent<MotherShip>();

        totResource = GameObject.Find("Game Master").GetComponent<TotalResources>();

        AS = this.gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // transform.RotateAround(this.gameObject.transform.position, Vector3.up, 20 * Time.deltaTime);

        if (motherShip.Clicked == true)
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
                //Cursor.SetCursor(cursorTexture1, hotSpot, cursorMode);

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    if (motherShip.MSAmmo >= 1)
                    {
                        AS.clip = ShootSFX;

                        AS.Play();

                        motherShip.MSAmmo--;

                        Instantiate(bulletOBJ, FirePos1.transform.position, FirePos1.transform.rotation);

                        Instantiate(bulletOBJ, FirePos2.transform.position, FirePos2.transform.rotation);

                        bulletOBJ.transform.LookAt(mousePosition);

                        //timer = 0;


                    }

                }
            }

        }

    }


}
