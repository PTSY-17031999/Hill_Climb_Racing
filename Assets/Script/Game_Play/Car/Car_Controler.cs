using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car_Controler : MonoBehaviour
{
    private Time_Bar_Main CN_Time_Bar_Main;
    private Game_Controler CN_GameControler;
    private Create_Coin_And_Carfuel Cn_Create_Coin_And_Carfuel;
    public Follow_Camera Taget; 
   

    private void Start()
    {
        CN_Time_Bar_Main = FindObjectOfType<Time_Bar_Main>();
        CN_GameControler = FindObjectOfType<Game_Controler>();
        Cn_Create_Coin_And_Carfuel = FindObjectOfType<Create_Coin_And_Carfuel>();
        Taget = FindObjectOfType<Follow_Camera>();
        Add_Camera(Taget);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Carfuel")){

            CN_Time_Bar_Main.Set_Again();
            Cn_Create_Coin_And_Carfuel.Create_Carfuel();
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("Coin"))
        {
            CN_GameControler.Plus_Score();
            Cn_Create_Coin_And_Carfuel.Create_Coin();
            Destroy(col.gameObject);
        }


    }

    private void Update()
    {

        if (CN_GameControler.Get_Pausegame() == true)
        {
            gameObject.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else gameObject.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }

    
    public void Add_Camera(Follow_Camera Fl_Cam)
    {
        Fl_Cam.transform.SetParent(transform);
        Fl_Cam.transform.localEulerAngles = Vector3.zero;
        Fl_Cam.transform.localPosition = new Vector3(5, 0, 0) ;
       
    }


    }
