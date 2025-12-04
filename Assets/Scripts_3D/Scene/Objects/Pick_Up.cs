using UnityEngine;

public class Pick_Up : MonoBehaviour
{
    public Playeritems Playeritems;
    public bool perfume = false;
    public bool invisibilidad = false;
    public bool key = false;
    public bool card = false;
    public GameObject Text;

    public void Start()
    {
        Text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Text.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            if (perfume)
            {
                Playeritems.perfume = true;
                gameObject.SetActive(false);
                Text.SetActive(false);
            }
            if (invisibilidad)
            {
                Playeritems.insisibilidad = true;
                gameObject.SetActive(false);
                Text.SetActive(false);
            }
            if (key)
            {
                Playeritems.master_key = true;
                gameObject.SetActive(false);
                Text.SetActive(false);
            }
            if (card)
            {
                Playeritems.gard_card = true;
                gameObject.SetActive(false);
                Text.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }
}
