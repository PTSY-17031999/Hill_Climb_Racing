using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[ExecuteInEditMode]
public class Cotroler_Stages_Ground : MonoBehaviour
{
    [SerializeField] private SpriteShapeController Spiete_Cotroler;

    [SerializeField, Range(3f, 100f)] private int _LevelLength = 50;
    [SerializeField, Range(1f, 50f)] private float X_Stage = 2f;
    [SerializeField, Range(1f, 50f)] private float  Y_Stage = 2f;
    [SerializeField, Range(0f, 1f)] private float CurveSmoothness = 50; //Dộ công của đường
    [SerializeField] private float Noise_Step = .5f;
    [SerializeField] private float _Bottom = 10f;
    private Vector3 _LastPos;

    private void OnValidate()
    {
        Spiete_Cotroler.spline.Clear();
        for(int i = 0; i < _LevelLength; i++)
        {
            _LastPos = transform.position + new Vector3(i * X_Stage, Mathf.PerlinNoise(0, i * Noise_Step) * Y_Stage);
            Spiete_Cotroler.spline.InsertPointAt(i, _LastPos);

            if(i !=0 && i != _LevelLength - 1)
            {
                Spiete_Cotroler.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
                Spiete_Cotroler.spline.SetLeftTangent(i, Vector3.left * X_Stage * CurveSmoothness);
                Spiete_Cotroler.spline.SetRightTangent(i, Vector3.right * X_Stage * CurveSmoothness);
            }
        }

        Spiete_Cotroler.spline.InsertPointAt(_LevelLength, new Vector3(_LastPos.x, transform.position.y - _Bottom));
        Spiete_Cotroler.spline.InsertPointAt(_LevelLength + 1, new Vector3(transform.position.x, transform.position.y - _Bottom));
    }

}
