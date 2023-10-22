using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _Number { _1, _2, _3 }
public class CAD_car_buy_or_no : MonoBehaviour
{
    public GameObject Pannel_No_Buy;
    Data_Processing Connect_Script_Data_Processing;

    private void Start()
    {
        //Debug.Log(_Number);
        Connect_Script_Data_Processing = FindObjectOfType<Data_Processing>();
    }
}