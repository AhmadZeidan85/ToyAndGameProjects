using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KineticMovment : MonoBehaviour

{
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

  float displacement = 1;
        foreach (GameObject cube in cubes)
            {
                  
               
                displacement += 0.1f;
               float yNew = Mathf.Sin(Time.time * displacement);
               cube.transform.rotation = Quaternion.Euler(new Vector3(0, yNew * 45f, 0));
            
            }
         
          
        
    }
    }

   
