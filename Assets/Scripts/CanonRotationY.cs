using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonRotationY : MonoBehaviour
{
    Transform CanonFixed;
    public Transform ayakKismi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, atesKismi.transform.rotation.y, this.transform.rotation.z);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ayakKismi.rotation = Quaternion.Lerp(ayakKismi.rotation, Quaternion.Euler(0, 45, 0), 0.005f);

        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ayakKismi.rotation = Quaternion.Lerp(ayakKismi.rotation, Quaternion.Euler(0, -45, 0), 0.005f);

        }
    }
}
