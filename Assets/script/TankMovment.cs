using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovment : MonoBehaviour

{

public Vector3 positionFactor = new Vector3(0.01f, 0.0f, 0.0f);    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKey(KeyCode.LeftArrow)) // Left Button
            {
                  transform.position -= positionFactor;
            }

            if (Input.GetKey(KeyCode.RightArrow))  // Right Button
             {
                 transform.position += positionFactor;
             }
        
    }
}
