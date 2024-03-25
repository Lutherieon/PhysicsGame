using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CononRotation : MonoBehaviour
{
    [SerializeField] float t;
    public Transform atesKismi;
    public Transform ayak;
    void Start()
    {
    }

    void Update()
    {
        
        Vector3 parentDirection = ayak.forward;
        Quaternion targetRotation = Quaternion.LookRotation(parentDirection);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(-50f,targetRotation.eulerAngles.y + 90  , -90), t);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(0f, targetRotation.eulerAngles.y +90 , -90), t);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        // atesKismi.transform.localRotation = Quaternion.Euler(atesKismi.rotation.x, ayak.rotation.y + 90, atesKismi.rotation.z);
        //transform.rotation = Quaternion.Euler(Quaternion.identity.x, 90 - ayak.transform.rotation.y, Quaternion.identity.z);
        //atesKismi.transform.SetParent(transform);


        //if (Input.GetKey(KeyCode.D))
        //{

        //    atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(atesKismi.localRotation.x, 90 - ayak.transform.rotation.y, -90), t);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(atesKismi.localRotation.x,90- ayak.transform.rotation.y ,-90), t);
        //}
        


    }
}
