using UnityEngine;

public class Map_Configuraton : MonoBehaviour
{
    public Individual_Doors door1;
    public Individual_Doors door2;
    public Individual_Doors door3;
    public Individual_Doors door4;
    public Individual_Doors door5;
    public Individual_Doors door6;
    public int Noche;
    public Individual_Doors door7;
    public Individual_Doors door8;
    public Individual_Doors door9;

    private void Start()
    {
        if (Noche == 1)
        {
            door1.Close_Door(); 
            door2.Close_Door();
            door3.Close_Door();
            door4.Close_Door();
            door5.Close_Door();
            door6.Close_Door();

        }
        if (Noche == 2)
        {
            door7.Close_Door();
            door8.Close_Door();
            door9.Close_Door();
        }
        
    }

}
