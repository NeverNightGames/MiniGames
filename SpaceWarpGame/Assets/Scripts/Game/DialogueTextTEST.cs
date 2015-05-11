using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueTextTEST : MonoBehaviour {

    public Text tBox;

    public float letterPause = 0.2f;
    //public AudioClip sound;

    string message;

    // Use this for initialization
    void Start()
    {
        message = tBox.text;
        tBox.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            tBox.text += letter;

            //if (sound)
                //audio.PlayOneShot(sound);

            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }
}