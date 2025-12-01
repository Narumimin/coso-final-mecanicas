using UnityEngine;

public class Individual_Doors : MonoBehaviour
{
    public Animator animator;

    public void Open_Door()
    {
        animator.SetBool("character_nearby", true);
    }
    public void Close_Door()
    {
        animator.SetBool("character_nearby", false);
    }
}
