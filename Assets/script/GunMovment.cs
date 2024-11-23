using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovment : MonoBehaviour

{
     public float deg = 0f;
    public float angleInc = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.D))
            {
                deg = deg + angleInc;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                deg = deg - angleInc;
            }

            transform.rotation = Quaternion.Euler(new Vector3(0, deg, 0));
        
    }
}
