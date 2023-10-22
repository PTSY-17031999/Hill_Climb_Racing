using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Rigidbody_Coin_Carfuel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.CompareTag("Ground"))
        {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
