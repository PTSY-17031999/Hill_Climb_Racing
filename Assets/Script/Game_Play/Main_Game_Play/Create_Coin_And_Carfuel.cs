using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Coin_And_Carfuel : MonoBehaviour
{
    public GameObject PF_Carfuel;
    public GameObject PF_Coin;

    private float Location_Create_Y = 15f;
    private float Location_Create_X_Coin;
    private float Location_Create_X_Carfuel;
    private float Distance_Coin =30f;
    private float Distance_Carfuel = 60f;

    // Start is called before the first frame update
    void Start()
    {
        Location_Create_X_Carfuel = 60.67f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int _Miss = 5;
    public void Create_Coin()
    {
        if(_Miss > 0)
        {
            _Miss--;
            return;
        }

        // Vector3 Location_Coin_New = new Vector3(Location_Create_X_Coin + Distance_Coin, Location_Create_Y, 0);
        Location_Create_X_Coin += Distance_Coin;
        for (int i = 0; i <= 5; i++)
        {
            Debug.Log("Create Coin");
            Location_Create_X_Coin += 0.7f;
            Vector3 Location_Coin_New = new Vector3(Location_Create_X_Coin, Location_Create_Y, 0);
            Instantiate(PF_Coin, Location_Coin_New, Quaternion.identity);
        }
        _Miss = 5;



    }


    public void Create_Carfuel()
    {
        for (int i = 0; i <= 3; i++)
        {
            Location_Create_X_Carfuel += Distance_Carfuel;
            Vector3 Location_Coin_New = new Vector3(Location_Create_X_Carfuel, Location_Create_Y, 0);
            Instantiate(PF_Carfuel, Location_Coin_New, Quaternion.identity);
        }
       
    }
}
