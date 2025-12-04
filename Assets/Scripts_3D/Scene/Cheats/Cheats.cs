using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheats : MonoBehaviour
{
    public GameObject[] Enemy;
    public bool active;
    public int scenenum;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F1))
        {
            if (active == false)
            {
                for (global::System.Int32 i = 0; i < Enemy.Length; i++)
                {
                    Enemy[i].SetActive(false);
                }
                active = true;
            }
            else
            {
                for (global::System.Int32 i = 0; i < Enemy.Length; i++)
                {
                    Enemy[i].SetActive(true);
                }
                active = false;
            }


        }
        if (Input.GetKey(KeyCode.F2))
        {
            SceneManager.LoadScene(scenenum);
        }
    }
}
