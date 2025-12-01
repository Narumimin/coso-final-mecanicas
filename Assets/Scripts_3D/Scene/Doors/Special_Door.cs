using Unity.VisualScripting;
using UnityEngine;

public class Special_Door : MonoBehaviour
{
    public Individual_Doors door1;
    public Playeritems playeritems;

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.O) && playeritems.gard_card)
        {
            door1.Open_Door();
        }
        if (Input.GetKeyDown(KeyCode.C) && playeritems.gard_card)
        {
            door1.Close_Door();
        }
    }
}
