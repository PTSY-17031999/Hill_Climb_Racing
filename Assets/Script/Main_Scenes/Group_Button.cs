using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Group_Button : MonoBehaviour
{
    public GameObject Scenes_Choose_Tune;
    public GameObject Scenes_Choose_Car;
    public GameObject Scenes_Choose_Stage;
    public GameObject Scenes_Main_Shop;

    #region Các map
    public GameObject Stage_1;
    #endregion

    #region Các Loại xe
    public GameObject Protagonist_1;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
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
                Scenes_Main_Shop.SetActive(false);
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

    }
}
