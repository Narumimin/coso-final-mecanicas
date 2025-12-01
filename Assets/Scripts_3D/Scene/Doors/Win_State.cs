using UnityEngine;

public class Win_State : MonoBehaviour
{

    public Individual_Doors door1;
    public Playeritems playeritems;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.O) && playeritems.gard_card)
        {
            // Load Win state maybe
        }
    }
}
