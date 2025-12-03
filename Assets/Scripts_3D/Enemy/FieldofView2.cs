using UnityEngine;

public class FieldofView2 : MonoBehaviour
{
    public Movment THISENEMY;
    public PlayerMovement player;

    private void OnTriggerEnter(Collider other)
    {
        if (player.agachado == false)
        {
            THISENEMY.currentstate = Movment.EnumStates.chase;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        THISENEMY.currentstate = Movment.EnumStates.wait;
    }
}
