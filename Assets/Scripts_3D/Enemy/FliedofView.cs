using UnityEngine;

public class FieldofViewEnemy : MonoBehaviour
{
    public Movment THISENEMY;

    private void OnTriggerEnter(Collider other)
    {
        THISENEMY.currentstate = Movment.EnumStates.chase;
    }
    private void OnTriggerExit(Collider other)
    {
        THISENEMY.currentstate = Movment.EnumStates.wait;
    }
}
