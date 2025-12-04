using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventos1 : MonoBehaviour
{
    public GameObject fadeInScreen;
    public GameObject fadeOutScreen;
    public GameObject dedGuardInSpace;
    public GameObject hallBG;

    [Header("Titania Sprites and stuff")]
    public GameObject titaniaStanding;
    public GameObject titaniaStandingRight;
    public GameObject titaniaShining;
    public GameObject titaniaEmbarassed;

    [Header("Guard Sprites")]
    public GameObject guardStanding;
    public GameObject disgustedGuard;
    public GameObject guardScared;

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
    public GameObject exitButton;
    private int eventPos;
    private bool eventActive;
    private bool skip = false;
    private string sigEvento;

    [Header("Choices")]
    public GameObject Choice1;
    public GameObject Choice2;

    private string currentSceneName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
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
        if (!eventActive)
        {
            StartCoroutine(sigEvento);
        }
    }

    public void C1O2()
    {
        eventPos = 28;
        NextButton();
    }

    public void C1O1()
    {
        eventPos = 37;
        NextButton();
    }

    public void C2O1()
    {
        eventPos = 40;
        NextButton();
    }

    public void C2O2()
    {
        eventPos = 28;
        NextButton();
    }

    public void TotalSkip()
    {
        StopAllCoroutines();
        VariablesGlobales.SkipDay1 = true;
        eventPos = 46;
        StartCoroutine(Event46());
    }

    IEnumerator EventStarter()
    {
        //Primer evento
        eventActive = true;
        eventPos = 0;
        fadeInScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        skipButton.SetActive(true);
        exitButton.SetActive(true);
        secondSkipButton.SetActive(true);
        titaniaStanding.SetActive(true);
        textBox.SetActive(true);
        arrow.SetActive(true);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Oh! You’re finally awake, dear, you humans sure do like to sleep a lot.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() =>  textLength == currentTextLength);
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "What the f- W- Where am I? Who are you? Wh-";
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
        textLines = "*She puts a finger in your mouth, shushing you.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "One thing at a time, you pretty little thing. You are in your new home! We borrowed you from your… Underdeveloped… Planet because we wanted to study you.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "You KIDNAPPED me?!";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You stand up from the bed and run towards the door.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = ".\n..\n...             *The door doesn’t budge.*\n";
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
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She grabs you by the arm, her fingers cold, as cold as her smile…*";
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
    IEnumerator Event8()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "It may seem you want a tour, let me indulge you.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She opens the door and guides you outside, not letting you out of her sight*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You feel a chill down your spine, it’s better if you <color=red>behave</color>.*";
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
            Debug.Log(eventPos);
        }
    }
    IEnumerator Event11()
    {
        hallBG.SetActive(true);
        eventActive = true;
        titaniaStanding.SetActive(false);
        titaniaStandingRight.SetActive(true);
        guardStanding.SetActive(true);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*In the hallway, you both run into a guard, he looks concerned.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Guard";
        textLines = "Your Majesty! Is that our specimen? What is it doing outside its room?";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "I fear that does not concern you. What I do with this pretty little thing is for me and me alone to know.";
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
        guardStanding.SetActive(false);
        guardScared.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She gives him a disapproving look, the guard stares in horror*";
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
        guardScared.SetActive(false);
        disgustedGuard.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Guard";
        textLines = "Your Majesty…! The King will be back in just 7 days, it is not seemly for the Queen to be fooling around with… These things.";
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
        guardScared.SetActive(true);
        disgustedGuard.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "I don’t think you understand, I said it <color=red>does not concern you</color>. Guards! Dispose of this… Filth.";
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
        guardScared.SetActive(false);
        titaniaStandingRight.SetActive(false);
        titaniaStanding.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*Guards rush to the site, taking him to a room labeled with symbols you can’t seem to understand.*";
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
    IEnumerator Event18()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You can’t see them anymore…*\n*You hear more doors open, then shut, grunts and then…*";
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
        textLines = "*Silence…*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*The Queen comes back out, no guard in sight. You give her a horrified look*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "You";
        textLines = "What will they do…?";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Put him in his place, of course";
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
        dedGuardInSpace.SetActive(true);
        titaniaStanding.SetActive(false);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She glances through the window, you follow her gaze and see the guard, lifeless, floating away.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "I really do not like it when they think they can stop a Queen like me from getting what she wants…";
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
        dedGuardInSpace.SetActive(false);
        titaniaStanding.SetActive(true);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She looks straight into your eyes.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "You are not that stupid… <color=red>Are you?</color>";
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
        bigAssButton.SetActive(false);
        secondSkipButton.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She’s waiting for an answer, and doesn’t look very patient.*\n*What will you say?*";
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
    IEnumerator Event28()
    {
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*Her features soften*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Good.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "She holds your chin, forcing you to look at her.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "But there’s no need for you to be so formal, you can call me Titania which is a version of my name you humans can understand.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She releases your face.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "Now then, you must be tired, I’ll take you back to your room, today must have been a lot for you to take in.";
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
        hallBG.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She takes you back to your room, and goes to the door.*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Titania";
        textLines = "I will see you tomorrow, dear. You better sleep… You will need it.";
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
        skipButton.SetActive(false);
        textLines = "*She closes the door, leaving you alone with your thoughts. Waiting for the lights to go out in order to attempt your escape*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            SceneManager.LoadScene("Night_1");
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(2);
        }
        fadeOutScreen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Night_1");
    }

    //C1O2 (FIRST CHOICE SECOND OPTION)
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event37()
    {
        VariablesGlobales.loveLevel += -10;
        Choice1.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She frowns*";
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
    IEnumerator Event38()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "That is not the answer I expected from you, I thought you would be more intelligent than to insult me right to my face… Especially knowing how easily I can make you disappear.";
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
        bigAssButton.SetActive(false);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Try again.";
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
    IEnumerator Event40()
    {
        Choice2.SetActive(false);
        bigAssButton.SetActive(true);
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "It seems we have borrowed the wrong specimen…";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Clearly we would be wasting our time studying the <color=red>likes of you</color>. Such a shame…";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "At least you will look pretty outside my window.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Guards, dispose of this specimen at once! It has served its purpose on this ship and I wish to gaze at it no longer.";
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
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*They take you to the same room where they took the other guard…*\n*You glance at the Queen, she’s not looking your way.*";
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
        skipButton.SetActive(false);
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You close your eyes…*\n*Never to open them again.*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            SceneManager.LoadScene(currentSceneName);
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(2);
        }
        fadeOutScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(currentSceneName);
    }

    //SKIP OPTION
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    IEnumerator Event46()
    {
        skip = false;
        secondSkipButton.SetActive(false);
        eventActive = true;
        TextCreator.runTextPrint = false;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*You start to disassociate, staring blankly at the queen’s face, thinking about how to escape this ship… And what your new life will be if you don’t manage to*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Are you even listening to me?";
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
        VariablesGlobales.loveLevel -= 20;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She looks at you, with a frown that only conveys pure anger*";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "Ugh, forget it, I refuse to partake in this conversation any longer if you will continue to be this… Disrespectful.";
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
    IEnumerator Event50()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She throws a disdained look your way*";
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
    IEnumerator Event51()
    {
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "I thought you were going to be more fun.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She leaves the room, leaving the door open as she looks back at you*";
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
        eventActive = true;
        NameText.GetComponent<TMPro.TMP_Text>().text = "Alien Queen";
        textLines = "I recommend you fix that horrible attitude before tomorrow morning, or that corpse will not be floating outside alone.";
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
        NameText.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textLines = "*She closes the door, leaving you alone with your thoughts. Waiting for the lights to go out in order to attempt your escape*";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textLines;
        currentTextLength = textLines.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        if (skip)
        {
            SceneManager.LoadScene("Night_1");
        }
        else if (!skip)
        {
            yield return new WaitForSeconds(2);
        }
        fadeOutScreen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Night_1");
    }
}
