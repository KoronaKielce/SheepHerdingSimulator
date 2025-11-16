using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetection : MonoBehaviour
{
    public GameObject Character;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Instantiate(Character, Character.transform.position, Quaternion.identity);
        }
    }
}
