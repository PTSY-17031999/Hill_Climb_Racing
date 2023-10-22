using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_handling_Body_and_Stage : MonoBehaviour
{
    Game_Controler CN_Game_Controler;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CN_Game_Controler = FindObjectOfType<Game_Controler>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Body"))
        {
            CN_Game_Controler.Set_Overgame(true);
        }
    }
}
