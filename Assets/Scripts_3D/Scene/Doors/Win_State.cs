using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_State : MonoBehaviour
{

    public Individual_Doors door1;
    public Playeritems playeritems;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && playeritems.gard_card)
        {
            SceneManager.LoadScene(4);
        }
    }
}
