using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class Tmer : MonoBehaviour
{

    public int Seconds = 10;
    public int Maxseconds;
    public bool count = true;
    public static float score;
    public int scenenum;
    public GameObject dAYTIME;


    private void Start()
    {
        Maxseconds = Seconds;
    }

    // Update is called once per frame
    void Update()
    {

        if (count)
        {
            StartCoroutine(Lecture());
            Seconds = Seconds - 1;
        }
        if (Seconds == 0)
        {
            count = false;
            SceneManager.LoadScene(scenenum);
        }
        if (Seconds <= 30)
        {
            dAYTIME.SetActive(true);
        }


    }

    private IEnumerator Lecture()
    {
        count = false;
        yield return new WaitForSeconds(1);
        count = true;
    }
}
