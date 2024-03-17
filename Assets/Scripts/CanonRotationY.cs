using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonRotationY : MonoBehaviour
{
    Transform CanonFixed;
    public Transform atesKismi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, atesKismi.transform.rotation.y, this.transform.rotation.z);
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 45, 0), 0.01f);

        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -45, 0), 0.01f);

        }
    }
}
