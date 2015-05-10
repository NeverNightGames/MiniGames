using UnityEngine;
using System.Collections;

public class TurretTEST : MonoBehaviour
{

    //public float bulletSpeed;

    public GameObject bulletOBJ;


    public GameObject FirePos1;

   // public GameObject FirePos2;


    public bool Fired;

    public float timer = 0f;


    private bool Clicked = false;

    private bool canFire;


    // Use this for initialization
    void Start()
    {

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

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    //print("G");

                    //bulletOBJ.transform.Translate(bulletSpeed, 0, 0 * Time.deltaTime);

                    Instantiate(bulletOBJ, FirePos1.transform.position, FirePos1.transform.rotation);

                    bulletOBJ.transform.LookAt(mousePosition);

                   // bulletOBJ.GetComponent<Rigidbody2D>().AddForce(bulletOBJ.transform.forward * 200);

                    

                    //Instantiate(bulletOBJ, FirePos2.transform.position, Quaternion.identity);

                    Fired = true;



                    //bulletOBJ.transform.rotation = this.gameObject.transform.rotation;

                }
            }

            if (Fired == true)
            {
                timer += Time.fixedDeltaTime;

                if (timer >= 0.1f)
                {
                    Fired = false;

                    timer = 0;
                }
            }
        }






        //bulletOBJ.transform.Translate(bulletSpeed, 0, 0 * Time.deltaTime);


    }

    void OnMouseDown()
    {
        //print("CICKED");

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
