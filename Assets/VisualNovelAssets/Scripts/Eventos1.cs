using System.Collections;
using UnityEngine;

public class Eventos1 : MonoBehaviour
{
    public GameObject fadeInScreen;
    public GameObject textBox;
    [SerializeField] string textLines;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // Update is called once per frame
    void Update()
    {
       textLength = TextCreator.charCount;
    }

    IEnumerator EventStarter()
    {
        fadeInScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        textLines = "Primera linea del juego yaay";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitUntil(() =>  textLength == currentTextLength);
        yield return new WaitForSeconds(2);
        textLines = "Segunda linea del juego yaay";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
    }

}
