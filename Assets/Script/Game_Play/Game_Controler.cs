using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Controler : MonoBehaviour
{
    [SerializeField] int Score;
    [SerializeField] bool Is_Overgame;
    [SerializeField] bool Is_Pausegame;
    private Data_Processing Cn_Data_Processing;

    private Manage_Ui_Gameplay CN_Manage_Ui_Gameplay;
    public GameObject Pannel_Over_game;
    private Audio_Controller CN_Audio_Controller;

    private void Start()
    {
        Cn_Data_Processing = FindObjectOfType<Data_Processing>();
        CN_Manage_Ui_Gameplay = FindObjectOfType<Manage_Ui_Gameplay>();
        Is_Pausegame = false;
        Is_Overgame = false;
        if(Score >= Cn_Data_Processing.Get_Score())
        {
            CN_Manage_Ui_Gameplay.Change_Score(Score);
        }
        else
        {
            CN_Manage_Ui_Gameplay.Change_Score(Cn_Data_Processing.Get_Score());
        }

        CN_Audio_Controller = FindObjectOfType<Audio_Controller>();
    }


    public void Plus_Score()
    {
        Score = Cn_Data_Processing.Get_Score() + 1;
        CN_Audio_Controller.Play_PlusCoin_sound();
        CN_Manage_Ui_Gameplay.Change_Score(Score);
        Cn_Data_Processing.Set_Score(Score);

    }
    public int Get_Score()
    {
        return Score;
    }

    public void Set_Overgame(bool Game_over)
    {
        Pannel_Over_game.SetActive(true);
        CN_Audio_Controller.Play_OverGame_sound();
        Is_Overgame = Game_over;
        Set_Pause();
    }

    public bool Get_Overgame()
    {
        return Is_Overgame;
    }


    public void Set_Pause()
    {
        if (Is_Pausegame == true)
        {
            Is_Pausegame = false;
        }
        else { Is_Pausegame = true; }

        CN_Manage_Ui_Gameplay.Change_Image_Button_Pause(Is_Pausegame);
    }

    public bool Get_Pausegame()
    {
        return Is_Pausegame;
    }


    public void Go_home()
    {
        SceneManager.LoadScene("Scenes_Main_And_Show");
    }

    public void Play_Again()
    {
        SceneManager.LoadScene("Scenes_Main_Play");
    }
}
