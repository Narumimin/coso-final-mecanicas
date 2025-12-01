using Unity.VisualScripting;
using UnityEngine;

public class Special_Door : MonoBehaviour
{
    public Individual_Doors door1;
    public Playeritems playeritems;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.O) && playeritems.master_key)
        {
            door1.Open_Door();
        }
        if (Input.GetKey(KeyCode.C) && playeritems.master_key)
        {
            door1.Close_Door();
        }
    }
}
