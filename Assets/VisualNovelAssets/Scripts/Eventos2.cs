using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventos2 : MonoBehaviour
{
    public GameObject fadeInScreen;
    public GameObject fadeOutScreen;

    [Header("Titania Sprites and stuff")]
    public GameObject titaniaStanding;
    public GameObject titaniaShining;
    public GameObject titaniaEmbarassed;

    [Header("Stuff for text")]
    public GameObject NameText;
    public GameObject textBox;
    public GameObject arrow;
    [SerializeField] string textLines;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;

    [Header("Stuff for the events")]
    public GameObject skipButton;
    public GameObject bigAssButton;
    public GameObject secondSkipButton;
    private int eventPos;
    private bool eventActive;
    private bool skip = false;
    private string sigEvento;

    [Header("Choices")]
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;

    [Header("Choice2 Crossroad")]
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject option5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        StartCoroutine(EventStarter());
    }

    // Update is called once per frame
    void Update()
    {
        textLength = TextCreator.charCount;
    }

    public void SkipButton()
    {
        if (!skip)
        {
            skip = true;
            TextCreator.textScrollSpeed = 0.0001f;
        }
        else if (skip)
        {
            skip = false;
            TextCreator.textScrollSpeed = 0.01f;
        }
    }

    public void NextButton()
    {
        sigEvento = "Event" + eventPos;
        Debug.Log(sigEvento);
        if (!eventActive)
        {
            StartCoroutine(sigEvento);
        }
    }
    public void TotalSkip()
    {
        StopAllCoroutines();
        VariablesGlobales.SkipDay1 = true;
        eventPos = 46;
        //StartCoroutine(Event46());
    }
    public void C1O1()
    {
        eventPos = 8;
        NextButton();
    }

    public void C1O2()
    {
        eventPos = 18;
        NextButton();
    }
    public void C1O3()
    {
        eventPos = 38;
        NextButton();
    }

    public void C2O1()
    {
        eventPos = 51;
        NextButton();
    }
    public void C2O2()
    {
        eventPos = 60;
        NextButton();
    }
    public void C2O3()
    {
        eventPos = 62;
        NextButton();
    }
    public void C2O4()
    {
        eventPos = 68;
        NextButton();
    }

    public void C2O5()
    {
        eventPos = 99;
        NextButton();
    }
    public void C3O1()
    {
        eventPos = 81;
        NextButton();
    }

    public void C3O2()
    {
        eventPos = 98;
        NextButton();
    }

    IEnumerator EventStarter()
    {
        //Primer evento
        eventActive = true;
        eventPos = 0;
        fadeInScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        skipButton.SetActive(true);
        secondSkipButton.SetActive(true);
        titaniaStanding.SetActive(true);
        textBox.SetActive(true);
        arrow.SetActive(true);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You wake up from a quick nap, running around the ship searching for useful objects left you exhausted, but lights are on and it won’t be long before Titania comes to check on you.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 1;
        }
    }
    IEnumerator Event1()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You stretch and change into some of the clothes they left for you, they look like a glorified hospital gown, you are… Uhm, thrilled to use it. So you put it on.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event2()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She walks in right after you finish changing.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event3()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Oh my!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event4()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She looks you up and down*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event5()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I believed humans found it inappropriate to show their ankles so openly in front of anyone but their spouse!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event6()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "So either I was wrong, <size=35>which I never am,</size> or you wanted to get a reaction out of me, dear! So, which one is it?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event7()
    {
        bigAssButton.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She looks at you, biting her finger with a wicked grin across her face.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        Choice1.SetActive(true);
        eventActive = false;
    }

    //C1O1 (FIRST CHOICE FIRST OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////

    IEnumerator Event8()
    {
        Choice1.SetActive(false);
        secondSkipButton.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*Her smile gets crooked.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event9()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "What did you just say to me?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event10()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "I- It was just a joke, I thought-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event11()
    {
        ;
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I don’t think you understand the position you are in, this is no “Circus” or whatever you humans call it for you to be saying those kinds of things.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event12()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "It seems you were not the right human to borrow. I’ll have to send you back and look for another one.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event13()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Wait so I can leave?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event14()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "No silly, that was one of your “jokes”.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event15()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She grins.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event16()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "We will throw you off the ship, and watch you suffocate. This part isn’t a “joke” just so you’re aware. GUARDS!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event17()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Our specimen is not welcome aboard anymore, dispose of it.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            SceneManager.LoadScene("Lose");
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(2);
        }
        fadeOutScreen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Lose");
    }

    //C1O2 (FIRST CHOICE SECOND OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event18()
    {
        VariablesGlobales.loveLevel += 15;
        Choice1.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I knew you would be an interesting specimen. Alright then, no more games. What else would you be willing to show me?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event19()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She gets closer to you.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event20()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "I could show you the intricacies of human courting rituals first hand.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event21()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You raise an eyebrow flirtily.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event22()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Human courting rituals? But courting rituals and mating rituals are different, are they not?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event23()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You start to sweat.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event24()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Oh well you see-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event25()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I know you humans refer to it as “The Devil’s Tango”. Would you not rather show me that instead?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event26()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You scoot further away.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event27()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Ah yes, tango… I am not very skilled at tango…";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event28()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You laugh awkwardly.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event29()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Well, how about I teach you about ours~? Just wait and see.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event30()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "WAIT! In uh… Human custom we don’t realize mating rituals so soon you see…";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event31()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She deflates, then sighs.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event32()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "So what do you do first, then?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event33()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "We talk and get to know each other better and-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event34()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "And then you partake in mating rituals?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event35()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "No- A-... A bit later.?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event36()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She huffs.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event37()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Ttiania";
        textLines = "Fine… Then I guess we must get to know each other better first.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C1O3 (FIRST CHOICE THIRD OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event38()
    {
        titaniaStanding.SetActive(false);
        titaniaEmbarassed.SetActive(true);
        VariablesGlobales.loveLevel += 8;
        Choice1.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Oh, uh…";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event39()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She blushes in embarrassment.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event40()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "It appears I have to dispose of one of our scientists… They don’t seem to be very good at their job.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event41()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She closes her eyes and smiles at you, but you have a feeling that she’s not happy about this.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event42()
    {
        eventActive = true;
        titaniaEmbarassed.SetActive(false);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She stands up and goes to the door. You see her talking to a nearby guard.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event43()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You sit on the bed, dangling your feet while you wait, attempting an escape with her there would be suicide.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event44()
    {
        titaniaStanding.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She comes back.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event45()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "It will be taken care of. Thank you for correcting my useless scientist.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event46()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She smiles at you. <color=red>You hear distant screaming</color>.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event47()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Uh well… How about we change the topic?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event48()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She sits next to you.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event49()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Ooh, of course, talking with you is always a delight!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }

    //Routes join
    //////////////////////////////////////////////////////////////////////////////////////////////////////

    IEnumerator Event50()
    {
        titaniaEmbarassed.SetActive(false);
        titaniaShining.SetActive(false);
        titaniaStanding.SetActive(true);
        bigAssButton.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "What did you have in mind?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        Choice2.SetActive(true);
        eventActive = false;
    }

    //C2O1 (SECOND CHOICE FIRST OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////

    IEnumerator Event51()
    {
        VariablesGlobales.loveLevel += -5;
        bigAssButton.SetActive(true);
        option1.SetActive(false);
        Choice2.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Only if you don’t behave. Or if you’re rude. Or if you try to escape… Or if I get bored of you…";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event52()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Probably <color=green>[frog sounds]</color> will also kill you if he sees me with you… So most likely, yes.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event53()
    {
        ;
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She nods, smiling.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event54()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Uh… Okay…? And who is <color=orange>[botched frog sounds]</color>";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event55()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Who?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event56()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Uhm… <color=orange>[A bit less botched frog sounds?]</color>?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event57()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Why are you saying such things about antidisestablishmentarianism?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event58()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She looks at you, concerned and a bit disgusted.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event59()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "You know what… Forget it.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C2O2 (SECOND CHOICE FIRST OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event60()
    {
        bigAssButton.SetActive(true);
        option2.SetActive(false);
        Choice2.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "We were really curious how a… Planet… As underdeveloped as yours could survive this long.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event61()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "We thought it was impossible for a race to survive this long without making any important discoveries, so we take specimens to experiment on and find the answer.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 77;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 77;
        }
    }

    //C2O3 (SECOND CHOICE THIRD OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event62()
    {
        VariablesGlobales.loveLevel += -5;
        bigAssButton.SetActive(true);
        option3.SetActive(false);
        Choice2.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Oh, that. Yes I am married, but my husband spends so much time on intergalactic trips that it’s impossible for a woman as insatiable as myself to sit still for so many lonely nights.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event63()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "So I have to seek entertainment… Elsewhere";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event64()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She checks you out*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event65()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "And… Does he know? Is he not bothered by it?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event66()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She smiles slyly*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event67()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "What <color=green>[frog sounds]</color> doesn’t know won’t hurt him.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C2O4 (SECOND CHOICE FOURTH OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event68()
    {
        VariablesGlobales.loveLevel += 5;
        bigAssButton.SetActive(true);
        option4.SetActive(false);
        Choice2.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Well, as you know, I am Titania, but my real name is <color=green>[frog sounds]</color>.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event69()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I am the Queen of <color=green>[unintelligible frog sounds]</color> inhabited by the <color=green>[more frog sounds]</color> a race generally thirsting for knowledge about other… Inferior races.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event70()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Although my particular interest about these races is the different amplexus rituals.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event71()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She smiles at you.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event72()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "And I must say…sometimes they make the most eye-catching discoveries.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event73()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She winks(?) at you froggishly, but not entirely unattractive.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event74()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Wait wait, amplexus? What’s that?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event75()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "We can talk about that later.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event76()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She winks again.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C3 ROUTE
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event77()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Oh uh… Well then, what do you like the most about my planet?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event78()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Well, I find the patterns of the animals you humans designated as “Cows” astonishing. I even managed to commission a perfume with their smell. Want to smell it?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event79()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "No, thank you.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event80()
    {
        bigAssButton.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "A shame, however, would you like to hear what we’ve gathered about the amazing and peculiar “Cows”?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        Choice3.SetActive(true);
        eventActive = false;
    }

    //C3O1 (THIRD CHOICE FIRST OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event81()
    {
        titaniaStanding.SetActive(false);
        titaniaShining.SetActive(true);
        VariablesGlobales.loveLevel += 20;
        bigAssButton.SetActive(true);
        Choice3.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Amazing! You see, based on all the knowledge we’ve gathered we have gotten ourselves a lot of information on those stunning creatures!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event82()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Did you know that Cows have 4 stomachs? And that the largest one of those can hold up to 50 pyfrlings of food? And they just keep all their food stored until they burp it out!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event83()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I don’t know what “burp” is but it sounds astonishing!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event84()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Burping is-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event85()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "And did you know that they can sleep while standing?! What incredible capabilities these “Cows” possess!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event86()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Wait but they can’t sleep while-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event87()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "And were you aware that they cannot see the color krelp? Poor creatures!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event88()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "What even is krelp?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event89()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "And they have pastimes! And their favorite one is…";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event90()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Is…?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event91()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Doing this!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event92()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She starts chewing air in front of you.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event93()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "They spend around 40% of their time doing that thing!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event94()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "Chewing?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event95()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I do not know what that is. BUT I do know that they have 32 feet! I think that’s what you call it, or was it teeth? You know the ones.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event96()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Oh! And-";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event97()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*Another 2 hours go by while hearing more cow facts*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C3O2 (THIRD CHOICE SECOND OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event98()
    {
        VariablesGlobales.loveLevel += -20;
        bigAssButton.SetActive(true);
        Choice3.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She gives you an extremely dissapointed look*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos = 50;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos = 50;
        }
    }

    //C2O5 (SECOND CHOICE FITH OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event99()
    {
        Choice2.SetActive(false);
        skipButton.SetActive(false);
        secondSkipButton.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = " Oh dear. Look at the time! It’s almost five blingajings past niffrin! I think it’s been enough supervising for today. I am going to go back to my beauty sleep, this face won’t stay this beautiful by itself.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            eventActive = false;
            eventPos += 1;
            sigEvento = "Event" + eventPos;
            StartCoroutine(sigEvento);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(0.5f);
            eventActive = false;
            eventPos += 1;
        }
    }
    IEnumerator Event100()
    {

        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Sleep tight, little experiment";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            SceneManager.LoadScene("Night_2");
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(2);
        }
        fadeOutScreen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Night_2");
    }
}
