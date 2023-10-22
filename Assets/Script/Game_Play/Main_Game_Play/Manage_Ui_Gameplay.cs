using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage_Ui_Gameplay : MonoBehaviour
{


    #region Score
    public List<GameObject> Score_Unit;
    public List<GameObject> Score_Dozen;
    public List<GameObject> Score_Hundred;
    #endregion

    public GameObject Button_Play;
    public GameObject Button_Pause;

    
    public void Start()
    {
        // Ẩn toàn bộ các các số thời gian và điểm
        for (int i = 0; i <= Score_Unit.Count - 1; i++)
        {
            // Ẩn toàn bộ điểm khi khởi chạy
            Score_Unit[i].SetActive(false);
            Score_Dozen[i].SetActive(false);
            Score_Hundred[i].SetActive(false);

        }
        processing(0, Score_Unit, Score_Dozen, Score_Hundred, null);
    }

   
    private void Update()
    {
       
    }




    // Xử lý điểm chơi
    public void Change_Score(int Score)
    {
        processing(Score, Score_Unit, Score_Dozen, Score_Hundred, null);

    }



    // Xử lý chuyển số sang hình ảnh
    void processing(int number, List<GameObject> Unit, List<GameObject> Dozen, List<GameObject> Hundred, List<GameObject> Thousand)
    {
        
        for (int i = 0; i <= Unit.Count - 1; i++)
        {
            if (Unit != null) Unit[i].SetActive(false);
            if (Dozen != null) Dozen[i].SetActive(false);
            if (Hundred != null) Hundred[i].SetActive(false);
            if (Thousand != null) Thousand[i].SetActive(false);
        }


        if (number > 9999) return;
        string a = number.ToString();
        if (a.Length == 1 & Unit != null) Unit[int.Parse(a[0].ToString())].SetActive(true);
        if (a.Length == 2 & Unit != null & Dozen != null)
        {
            Unit[int.Parse(a[1].ToString())].SetActive(true);
            Dozen[int.Parse(a[0].ToString())].SetActive(true);
            }
        if (a.Length == 3 & Unit != null & Dozen != null & Dozen != null)
        {
            Unit[int.Parse(a[2].ToString())].SetActive(true);
            Dozen[int.Parse(a[1].ToString())].SetActive(true);
            Hundred[int.Parse(a[0].ToString())].SetActive(true);
        }
        if (a.Length == 4 & Unit != null & Dozen != null & Dozen != null & Thousand != null)
        {
            Dozen[int.Parse(a[3].ToString())].SetActive(true);
            Unit[int.Parse(a[2].ToString())].SetActive(true);
            Hundred[int.Parse(a[1].ToString())].SetActive(true);
            Thousand[int.Parse(a[0].ToString())].SetActive(true);
        }
        


    }

    public void Change_Image_Button_Pause(bool Is_Check)
    {

        Button_Pause.SetActive(Is_Check);
        Button_Play.SetActive(!Is_Check);
    }
}
