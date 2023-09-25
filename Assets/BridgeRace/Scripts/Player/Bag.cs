using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public float offsetBtwBrick = 0.3f;
    public List<Brick> _listBrick = new List<Brick>();

    public void AddBrick(Brick brick)
    {
        // Add Viên gạch khi trong túi chưa có viên gạch nào
        if (_listBrick.Count == 0)
        {
            brick.transform.SetParent(transform);
            brick.transform.localEulerAngles = Vector3.zero;
            brick.transform.localPosition = Vector3.zero;
            _listBrick.Add(brick);
            return;
        }

        // Add Viên gạch khi trong túi đã có gạch.
        var latestBrick = _listBrick[_listBrick.Count - 1];
        var latestPos = latestBrick.transform.localPosition;
        var newPos = latestPos + new Vector3(0, offsetBtwBrick, 0);

        brick.transform.SetParent(transform);
        brick.transform.localEulerAngles = Vector3.zero;
        brick.transform.localPosition = newPos;
        _listBrick.Add(brick);
    }

    public Brick Move_Brick_Out()
    {
        Brick brick = _listBrick[_listBrick.Count - 1];
        _listBrick.RemoveAt(_listBrick.Count - 1);
        return brick;
    }
}
