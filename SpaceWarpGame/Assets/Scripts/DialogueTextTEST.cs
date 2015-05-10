using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueTextTEST : MonoBehaviour {

    public Text MyText;
   // public Text BinaryText;

    //public GameObject TheBinaryText;
    public GameObject TheTextObject;

    public string MyTextString;
   // public string MyBinaryString;

    char[] MyArray;
    //char[] BinaryArray;

    // Use this for initialization
    void Start()
    {
        MyText = TheTextObject.gameObject.GetComponent<Text>();
        MyTextString = MyText.text;
        MyArray = MyTextString.ToCharArray();

        //BinaryText = TheBinaryText.gameObject.GetComponent<Text>();
        //MyBinaryString = BinaryText.text;
        //BinaryArray = MyBinaryString.ToCharArray();


       // StartCoroutine(Translation());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Starts the random thing below
            //StartCoroutine(ChangeRandomCharacter());
            //StartCoroutine(TitleGlitch());
        }

    }

    //public IEnumerator Translation()
    //{
    //    //for (int i = 0; i < BinaryArray.Length; i++)
    //    //{
    //    //    yield return new WaitForSeconds(0.001f);
    //    //    if (BinaryArray[i] == char.Parse(" "))
    //    //    {

    //    //        BinaryArray[i] = char.Parse(" ");
    //    //    }
    //    //    if (MyArray[i] == char.Parse("\n"))
    //    //    {
    //    //        BinaryArray[i] = char.Parse("\n");
    //    //    }
    //    //    else
    //    //    {
    //    //        BinaryArray[i] = MyArray[i];
    //    //        //	BinaryArray[i] = MyArray[i];
    //    //        //	Debug.Log("char ar " +i + " is: " + MyArray[i]);
    //    //    }
    //    //    BinaryText.text = new string(BinaryArray);

    //    }




    }
    #region Changes random characters to 0 or 1 to symbolize the corruption.
    //	public IEnumerator ChangeRandomCharacter()
    //	{
    //		float RandomTime = Random.Range (1, 3);
    //		int total = BinaryArray.Length;
    //		int RandomNumber = Random.Range (0, total);
    //		int RandomString = Random.Range (0, 1);
    //		string SaveChar = BinaryArray [RandomNumber].ToString;
    //		BinaryArray [RandomNumber] = char.Parse (RandomString);
    //		yield return new WaitForSeconds(1);
    //		BinaryArray [RandomNumber] = char.Parse (SaveChar);
    //
    //
    //	}
    #endregion

    //public IEnumerator TitleGlitch()
    //{
    //    int total = BinaryArray.Length;
    //    int randomnum = Random.Range(0, total);
    //    char test = BinaryArray[randomnum];
    //    BinaryArray[randomnum] = char.ToUpper(test);
    //    BinaryText.text = new string(BinaryArray);
    //    print("doing it" + BinaryArray[randomnum]);
    //    yield return new WaitForSeconds(2);
    //    BinaryArray[randomnum] = test;
    //    BinaryText.text = new string(BinaryArray);
    //    StartCoroutine(TitleGlitch());
    //}

