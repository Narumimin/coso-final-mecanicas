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
    public GameObject iNV_indic;
    public GameObject Item1, Item2, Item3, Item4;
    public Movment THISENEMY;
    public int night_num;

    public void Start()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
    }

    public void Update()
    {
        if (perfume)
        {
            Item1.SetActive(true);
        }
        else
        {
            Item1.SetActive(false);
        }
        if (insisibilidad)
        {
            Item2.SetActive(true);
        }
        else
        {
            Item2.SetActive(false);
        }
        if (gard_card)
        {
            Item3.SetActive(true);
        }
        else
        {
            Item3.SetActive(false);
        }
        if (master_key)
        {
            Item4.SetActive(true);
        }
        else
        {
            Item4.SetActive(false);
        }




        if (Input.GetKeyDown(KeyCode.Q) && insisibilidad)
        {
            StartCoroutine(Duration());
        }

    }

    private IEnumerator Duration()
    {
        field_of_view_en1.SetActive(false);
        iNV_indic.SetActive(true);
        THISENEMY.currentstate = Movment.EnumStates.wait;
        yield return new WaitForSeconds(20);
        field_of_view_en1.SetActive(true);
        iNV_indic.SetActive(false);
        insisibilidad=false;
    }
}
