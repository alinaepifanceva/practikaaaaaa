using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public GameObject Gear;
    void Start()
    {
        Instantiate(Gear,transform.position,Quaternion.identity);
    }

   
    void Update()
    {
        
    }
}
