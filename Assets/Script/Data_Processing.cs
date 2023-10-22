using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Processing : MonoBehaviour
{
    public List<GameObject> Car;
    private List<GameObject> Car_stock;

    #region Xứ lý kho xe

    // Thêm xe vào kho xe đã mua.
    public void Add_Car_Stock(int i)
    {
        if (PlayerPrefs.GetString("Car_Stock") == null)
        {
            PlayerPrefs.SetString("Car_Stock", i.ToString());
        }
        else
        {
            for (int z = 0; z >= (char)PlayerPrefs.GetString("Car_Stock").Split(',').Length; z++)
            {
                if(PlayerPrefs.GetString("Car_Stock").Split(',')[z].ToString() == i.ToString())
                {
                    Debug.Log("Xe đã có trong kho");
                    return;
                }
            }
            
                string a = PlayerPrefs.GetString("Car_Stock") + ", " + i.ToString();
                PlayerPrefs.SetString("Car_Stock", a);
        }
    }


    // Danh sách các xe đã mua.
    public string Get_Car_Stock()
    {
        return PlayerPrefs.GetString("Car_Stock");
    }
    #endregion



    #region Xứ lý kho Stage
    // Thêm Map vào kho map đã mua
    public void Add_Stage_Stock(int i)
    {
        if (PlayerPrefs.GetString("Stage_Stock") == null)
        {
            PlayerPrefs.SetString("Stage_Stock", i.ToString());
        }
        else
            for (int z = 0; z >= (char)PlayerPrefs.GetString("Stage_Stock").Split(',').Length; z++)
            {
                if (PlayerPrefs.GetString("Stage_Stock").Split(',')[z].ToString() == i.ToString())
                {
                    Debug.Log("Xe đã có trong kho");
                    return;
                }
            }
            string a = PlayerPrefs.GetString("Stage_Stock") + i.ToString();
            PlayerPrefs.SetString("Stage_Stock", a);
        
    }


    // Danh sách các Stage đã mua.
    public string Get_Stage_Stock()
    {
        return PlayerPrefs.GetString("Stage_Stock");
    }
    #endregion


    #region Lựa chọn Car, Stage lấy giá trị đã chọn
    public void Set_Choose_Car(int i)
    {
        PlayerPrefs.SetInt("Choose_Car", i);
    }
    public void _Set_Choose_Stage(int i)
    {
        PlayerPrefs.SetInt("Choose_Stage", i);
    }

    public int Get_Choose_Car()
    {
       return PlayerPrefs.GetInt("Choose_Car");
    }
    public int Get_Choose_Stage()
    {
        return PlayerPrefs.GetInt("Choose_Stage");
    }
    #endregion


    #region Xứ lý điểm số
    public void Set_Score(int Score)
    {
        PlayerPrefs.SetInt("Score", Score);
    }
    public int Get_Score()
    {
       return PlayerPrefs.GetInt("Score");
    }
    #endregion


    #region Xử lý lựa chọn xe, map để chơi
    public void Set_Map_And_Car(int _Car, int _Map)
    {
        PlayerPrefs.SetInt("_Car", _Car);
        PlayerPrefs.SetInt("_Map", _Map);

    }
    public int Get_Map()
    {
        return PlayerPrefs.GetInt("_Map");

    }

    public int Get_Car()
    {
       return PlayerPrefs.GetInt("_Car");
    }

    #endregion
}
