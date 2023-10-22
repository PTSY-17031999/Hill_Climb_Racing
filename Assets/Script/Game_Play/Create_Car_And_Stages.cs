using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Car_And_Stages : MonoBehaviour
{
    public List<GameObject> PF_List_Car;
    public List<GameObject> PF_List_Stages;
    private Data_Processing CN_Data_Processing;
    // Start is called before the first frame update
    void Start()
    {
        CN_Data_Processing = FindObjectOfType<Data_Processing>();

        Instantiate(PF_List_Car[CN_Data_Processing.Get_Car()], new Vector3(0f, 0f, 0f) , Quaternion.identity);
        Instantiate(PF_List_Stages[CN_Data_Processing.Get_Map()], new Vector3(0f, -10f, 0f), Quaternion.identity);


    }

    
    
}
