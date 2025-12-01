using UnityEngine;

public class Map_Configuraton : MonoBehaviour
{
    public Individual_Doors door1;
    public Individual_Doors door2;
    public Individual_Doors door3;
    public Individual_Doors door4;
    public Individual_Doors door5;
    public int dia;

    private void Update()
    {
        if (dia == 1)
        {
            door1.Close_Door(); 
            door2.Close_Door();
            door3.Close_Door();
            door4.Close_Door();
            door5.Close_Door();
        }
        else
        {
            door1.Open_Door();
            door2.Open_Door();
            door3.Open_Door();
            door4.Open_Door();
            door5.Open_Door();
        }
    }

}
