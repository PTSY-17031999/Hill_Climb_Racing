using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    public AudioSource Conect_files_Source;
    public AudioClip Gas_sound;
    public AudioClip Over_Game_sound;
    public AudioClip Plus_Coin_sound;
    //public AudioClip Click_Button_sound;

    public void Play_Gas_sound() { 
         if (Conect_files_Source && Gas_sound)
            {
                Conect_files_Source.PlayOneShot(Gas_sound);
            }}
    public void Play_OverGame_sound()
    {
        if (Conect_files_Source && Over_Game_sound)
        {
            Conect_files_Source.PlayOneShot(Over_Game_sound);
        }
    }
    public void Play_PlusCoin_sound()
    {
        if (Conect_files_Source && Plus_Coin_sound)
        {
            Conect_files_Source.PlayOneShot(Plus_Coin_sound);
        }
    }
   

    private void Start()
    {
        //Check_On_Off_Audio();

    }

    // Khi cài đặt game trước khi vào chơi 
    //Chưa Xây dựng xong
    public void Check_On_Off_Audio()
    {
        if (PlayerPrefs.GetInt("Audio_play") == 0)
        {
            Conect_files_Source.Stop();
        }
        else Conect_files_Source.Play();
    }
}
