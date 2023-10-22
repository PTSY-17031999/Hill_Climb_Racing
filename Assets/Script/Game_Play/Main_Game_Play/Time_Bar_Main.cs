using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_Bar_Main : MonoBehaviour
{
    public static Time_Bar_Main Instance;


    [SerializeField] private Image _FuelImage;
    [SerializeField, Range(0.1f, 05f)] private float _FuelDrainSpeed = 2f;
    [SerializeField] private float _MaxFuelAmount = 100f;
    [SerializeField] private Gradient _FuelGradient;
    private float _CurrentFuelAmount;


    private Game_Controler CN_GameControler;

    void Awke()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        CN_GameControler = FindObjectOfType<Game_Controler>();
        _CurrentFuelAmount = _MaxFuelAmount;
        Update_Ui();
    }

    // Update is called once per frame
    void Update()
    {
        if(CN_GameControler.Get_Pausegame() == true) { return; }
        _CurrentFuelAmount -= Time.deltaTime * _FuelDrainSpeed;
        Update_Ui();
    }


    private void Update_Ui()
    {
        if(_CurrentFuelAmount <= 0)
        {
            CN_GameControler.Set_Overgame(true);
        }
        _FuelImage.fillAmount = (_CurrentFuelAmount / _MaxFuelAmount);
        _FuelImage.color = _FuelGradient.Evaluate(_FuelImage.fillAmount);
    }

    public void Set_Again()
    {
        _CurrentFuelAmount = _MaxFuelAmount;
        Update_Ui();

    }

}
