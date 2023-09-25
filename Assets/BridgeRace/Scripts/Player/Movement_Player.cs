using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public ColorType playerColor;
    public float speed = 10;
    Bag Bag_Brick;
    Build_bridge _Build_Bridge;

    private void Start()
    {
        Bag_Brick = FindObjectOfType<Bag>();
        _Build_Bridge = FindObjectOfType<Build_bridge>();
    }

    // Update is called once per frame
    void Update()
    {
        float xLeftRight = Input.GetAxis("Horizontal");
        float zForwardbackward = Input.GetAxis("Vertical");
        transform.position += new Vector3(xLeftRight, 0, zForwardbackward) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Player chạm vào viên gạch khi ăn viên gạch
        if (other.CompareTag("Brick"))
        {
            var brick = other.GetComponent<Brick>();
            if (brick != null)
            {
                var colorOfBrick = brick.brickColor;
                if (colorOfBrick == playerColor)
                {
                    Bag_Brick.AddBrick(brick);
                }
            }
        }

        // Player đi lên cầu
        if (other.CompareTag("Bridge"))
        {
            var brick = other.GetComponent<Brick>();
            if (brick != null)
            {
                 Bag_Brick.AddBrick(brick);
            }
        }
    }
}
