using Unity.VisualScripting;
using UnityEngine;

public class Special_Door : MonoBehaviour
{
    public Individual_Doors door1;
    public Playeritems playeritems;

    public void Start()
    {
        door1.Close_Door();
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Popo");
        if (Input.GetKey(KeyCode.E) && playeritems.master_key)
        {
            Debug.Log("Pepe");
            Debug.Log(door1.door);
            if (door1.door == false)
            {
                door1.Open_Door();
            }
            else
            {
                door1.Close_Door();
            }

        }
    }
}
