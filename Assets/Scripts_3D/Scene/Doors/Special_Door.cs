using Unity.VisualScripting;
using UnityEngine;

public class Special_Door : MonoBehaviour
{
    public Individual_Doors door1;
    public Playeritems playeritems;
    public GameObject Text;
    public GameObject Advertence;

    public void Start()
    {
        door1.Close_Door();
        Text.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        Text.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            if (playeritems.master_key)
            {
                if (door1.door == false)
                {
                    door1.Open_Door();
                }
                else
                {
                    door1.Close_Door();
                }
            }
            else
            {
                Advertence.SetActive(true);
            }

        }

    }
    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
        Advertence.SetActive(false);
    }
}
