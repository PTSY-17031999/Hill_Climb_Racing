using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive_Car : MonoBehaviour
{
    public Rigidbody2D Front_Tire;
    public Rigidbody2D Back_Tire;
    private float Speed = 200f;

    public Rigidbody2D _Car;
    float RotationSpeed = 300f;

    float Input_Move; //Nhận dữ liệu di chuyển

    Game_Controler CN_Game_Controler;
    private Audio_Controller CN_Audio_Controller;

    private void Start()
    {
        CN_Game_Controler = FindObjectOfType<Game_Controler>();
        CN_Audio_Controller = FindObjectOfType<Audio_Controller>();
    }


    // Update is called once per frame
    void Update()
    {


        Input_Move = Input.GetAxisRaw("Horizontal");
        if(Input_Move != 0 && CN_Game_Controler.Get_Overgame() != true)
        {
            CN_Audio_Controller.Play_Gas_sound();
        }else
        {

        }
    }

    // Chạy sau khi hàm Update chạy xong
    private void FixedUpdate()
    {
        if(CN_Game_Controler.Get_Pausegame() == true) { return; }

        Front_Tire.AddTorque(- Input_Move * Speed * Time.fixedDeltaTime); // quay bánh xe trên tầng khung hình
        Back_Tire.AddTorque(- Input_Move * Speed * Time.fixedDeltaTime); // quay bánh xe trên tầng khung hình
        _Car.AddTorque(Input_Move * RotationSpeed * Time.fixedDeltaTime); // Nghiêng xe theo hướng di chuyển
    }



    //private void
}
