using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject Bullet;
    private Transform shootPos;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        shootPos = GameObject.FindGameObjectWithTag("ShootPos").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(effect, shootPos.position,Quaternion.identity);
            Instantiate(Bullet, shootPos.position, Quaternion.identity);
        }
        
    }
}
