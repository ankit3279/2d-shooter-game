using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    Vector2 direction;
    //public float offset;
    void Update()
    {
        Vector2 wPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePosition - wPosition;
        transform.right = direction;
    }
}
