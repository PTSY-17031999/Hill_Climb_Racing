using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Group_Button : MonoBehaviour
{
    public GameObject Scenes_Choose_Tune;
    public GameObject Scenes_Choose_Car;
    public GameObject Scenes_Choose_Stage;
    public GameObject Scenes_Main_Shop;

    private Net_Choise_Car CN_Net_Choise_Car;
    private Data_Processing CN_Data_Processing;

    #region Các map
    public GameObject Stage_1;
    #endregion

    #region Các Loại xe
    public GameObject Protagonist_1;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        CN_Net_Choise_Car = FindObjectOfType<Net_Choise_Car>();
        CN_Data_Processing = FindObjectOfType<Data_Processing>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click_BTN(int i)
    {
        switch (i)
        {
            case 1:

                Scenes_Choose_Car.SetActive(false);
                Scenes_Choose_Stage.SetActive(false);
                Scenes_Choose_Tune.SetActive(true);
                Click_TUNE();
                break;
            case 2:
                Scenes_Choose_Car.SetActive(true);
              //  Scenes_Choose_Tune.SetActive(false);
                Scenes_Choose_Stage.SetActive(false);
                Click_BTN_CAR();
                break;
            case 3:
                Scenes_Choose_Stage.SetActive(true);
                Scenes_Choose_Car.SetActive(false);
               // Scenes_Choose_Tune.SetActive(false);
                Click_BTN_STAGE();
                break;
            case 4:
                Click_BTN_PLAY();
                break;

        }
    }


    void Click_TUNE()
    {

    }
    void Click_BTN_CAR()
    {

    }
    public void Click_BTN_STAGE()
    {

    }
    public void Click_BTN_PLAY()
    {
        CN_Data_Processing.Set_Map_And_Car(CN_Net_Choise_Car.Retumn_Choose_Car(), CN_Net_Choise_Car.Retumn_Choose_Stage());
        SceneManager.LoadScene("Scenes_Main_Play");
    }
}
