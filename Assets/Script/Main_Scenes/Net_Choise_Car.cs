using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net_Choise_Car : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private List<GameObject> List_Car;
    int Selected_location_Car; // Vị trí xe được chọn
    [SerializeField] private List<GameObject> List_Stage;
    int Selected_location_Stage; // Vị trí map được chọn

    int Move_left_or_right; // Di chuyển theo hướng trái hoặc phải
    [SerializeField] private float Speed;


    public GameObject Main_Car;
    public GameObject Main_Stage;

    void Start()
    {
        Selected_location_Car = 1;
    }

    // Update is called once per frame
   

   public void Click_back_button_Car()
    {
       
        if (List_Car.Count <= Selected_location_Car+1)
        {
            Move_left_or_right = 0;
        }
        else
        {
            Selected_location_Car++;
            Move_left_or_right = 1; // Sang trái
        }
            

    }
    public void Click_net_button_Car()
    {
       
        if (Selected_location_Car - 1 < 0)
        {
            Move_left_or_right = 0;
        }
        else
        {
            Selected_location_Car--;
            Move_left_or_right = 2; // Sang phải
        }
            

    }
    public void Click_back_button_Stage()
    {

        if (List_Stage.Count <= Selected_location_Stage + 1)
        {
            Move_left_or_right = 0;
        }
        else
        {
            Selected_location_Stage++;
            Move_left_or_right = 1; // Sang trái
        }


    }
    public void Click_net_button_Stage()
    {

        if (Selected_location_Stage - 1 < 0)
        {
            Move_left_or_right = 0;
        }
        else
        {
            Selected_location_Stage--;
            Move_left_or_right = 2; // Sang phải
        }


    }

    void Update()
    {
        if (Main_Car.activeInHierarchy == true) Scenes_Choose_car();
        if (Main_Stage.activeInHierarchy == true) Scenes_Choose_Stage();
       
    }

    //Màn hình chọn Stage (Map chơi)
    void Scenes_Choose_Stage()
    {
        //Click net button
        if (Move_left_or_right == 1 && List_Stage[Selected_location_Stage].transform.position.x >= 0)
        {
            for (int i = 0; i <= List_Stage.Count - 1; i++)
            {
                List_Stage[i].transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
                Scale_Icon(i);
            }
            return;
        }

        //Click net button
        if (Move_left_or_right == 2 && List_Stage[Selected_location_Stage].transform.position.x <= 0)
        {
            for (int i = 0; i <= List_Stage.Count - 1; i++)
            {
                List_Stage[i].transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
                Scale_Icon(i);
            }
            return;
        }
        Move_left_or_right = 0;
    }
    // Màn hình chọn Xe
    void Scenes_Choose_car()
    {
        //Click net button
        if (Move_left_or_right == 1 && List_Car[Selected_location_Car].transform.position.x >= 0)
        {
            for (int i = 0; i <= List_Car.Count - 1; i++)
            {
                List_Car[i].transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
                Scale_Icon(i);
            }
            return;
        }

        //Click net button
        if (Move_left_or_right == 2 && List_Car[Selected_location_Car].transform.position.x <= 0)
        {
            for (int i = 0; i <= List_Car.Count - 1; i++)
            {
                List_Car[i].transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
                Scale_Icon(i);
            }
            return;
        }
        Move_left_or_right = 0;
    }


    // Phóng to, thu nhỏ Icon
    void Scale_Icon( int i)
    {
        // Scale car
        if (Main_Car.activeInHierarchy == true)
        {
            if (i == Selected_location_Car)
            {
                if (List_Car[Selected_location_Car].transform.localScale.x <= 1.2f)
                {
                    List_Car[Selected_location_Car].transform.localScale += new Vector3(0.4f, 0.4f, 1f) * Time.deltaTime;
                }

            }
            if (List_Car[i].transform.localScale.x > 0.7f && i != Selected_location_Car)
            {
                List_Car[i].transform.localScale -= new Vector3(0.5f, 0.5f, 1f) * Time.deltaTime;
            }
        }
        // Scale stage
        if (Main_Stage.activeInHierarchy == true)
        {
            if (i == Selected_location_Stage)
            {
                if (List_Stage[Selected_location_Stage].transform.localScale.x <= 1.2f)
                {
                    List_Stage[Selected_location_Stage].transform.localScale += new Vector3(0.4f, 0.4f, 1f) * Time.deltaTime;
                }

            }
            if (List_Stage[i].transform.localScale.x > 0.7f && i != Selected_location_Stage)
            {
                List_Stage[i].transform.localScale -= new Vector3(0.5f, 0.5f, 1f) * Time.deltaTime;
            }
        }

    }



    public void Buy_Car()
    {

    }



    public int Retumn_Choose_Stage() {

        return Selected_location_Stage;
    }
    public int Retumn_Choose_Car()
    {

        return Selected_location_Car;
    }
    /*
        public IEnumerator ScaleObject(Vector3 targetPos, float duration)
        {
            float time = 0;
            float rate = 1 / duration;
            while (time < 1)
            {
                time += rate * Time.deltaTime;
                transform.localScale = targetScale * moveCurve.Evaluate(time);
                yield return 0;
            }
        }*/
}
