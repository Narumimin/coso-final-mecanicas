using UnityEngine;
using UnityEngine.SceneManagement;

public class Console : MonoBehaviour
{
    public GameObject Menu;
    public bool active = false;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (active == false)
            {
                Menu.SetActive(true);
                active = true;
            }
            else
            {
                Menu.SetActive(false);
                active = false;
            }


        }
    }
}
