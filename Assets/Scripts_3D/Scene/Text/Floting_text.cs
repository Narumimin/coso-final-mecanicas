using UnityEngine;
using UnityEngine.UI;

public class Floting_text : MonoBehaviour
{
    public PlayerMovement player;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position); // look at camera
    }
}
