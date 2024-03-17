using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CononRotation : MonoBehaviour
{
    [SerializeField] float t;
    public Transform atesKismi;
    public Transform ayakKismi;
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            
            atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(-50f, 0f, -45f), t);
        }
        if (Input.GetKey(KeyCode.S))
        {
            atesKismi.rotation = Quaternion.Lerp(atesKismi.rotation, Quaternion.Euler(-135f, 0f, -45f), t);
        }

        
      
    }
}
