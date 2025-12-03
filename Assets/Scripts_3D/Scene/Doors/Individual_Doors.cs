using UnityEngine;

public class Individual_Doors : MonoBehaviour
{
    public Animator animator;
    public bool door = true;

    public void Open_Door()
    {
        animator.SetBool("character_nearby", true);
        door = true;
    }
    public void Close_Door()
    {
        animator.SetBool("character_nearby", false);
        door = false;
    }
}
