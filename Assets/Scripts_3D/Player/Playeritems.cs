using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class Playeritems : MonoBehaviour
{
    public bool perfume = false;
    public bool insisibilidad = false;
    public bool gard_card = false;
    public bool master_key = false;
    public GameObject field_of_view_en1;
    public GameObject field_of_view_en2;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)&& insisibilidad)
        {
            StartCoroutine(Duration());
        }

    }

    private IEnumerator Duration()
    {
        field_of_view_en1.SetActive(false);
        field_of_view_en2.SetActive(false);
        yield return new WaitForSeconds(20);
        field_of_view_en1.SetActive(true);
        field_of_view_en2.SetActive(true);
        insisibilidad=false;
    }
}
