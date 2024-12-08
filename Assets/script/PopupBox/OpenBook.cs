using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bookFaceRight;
    public Transform bookFaceLeft;

     public Transform gift;


    float bookOpenSpeed = 30f;

    float value = 0f;

    float openAngle = 45; 
    float closeAngle=0;

    bool openBook=true;
    bool closeBook=true;

    Vector3 scaleFactor = new Vector3(0.01f, 0.01f, 0.02f);


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        openBookAction();
        closeBookAction();
        
    }



      void openBookAction()
    {
        
        Quaternion targetRotation = Quaternion.Euler(0,0 , openAngle);

        if (Input.GetKey(KeyCode.O))
        {
            if(openBook==true){

            bookFaceLeft.Rotate(new Vector3(0, 0, -Time.deltaTime * bookOpenSpeed), Space.Self);
            bookFaceRight.Rotate(new Vector3(0, 0, Time.deltaTime * bookOpenSpeed), Space.Self);
            gift.transform.localScale += scaleFactor;

            float angle1 = Quaternion.Angle(bookFaceRight.rotation, targetRotation);

            Debug.Log("angle1 "+  angle1);
            
            if(angle1<0.1f){

                Debug.Log("reach traget analge");
                openBook=false;
                closeBook=true;
            }

           



            }

              
        }
        
    }

     void closeBookAction()
    {
        
        Quaternion targetRotation = Quaternion.Euler(0,0 , closeAngle);

        if (Input.GetKey(KeyCode.C))
        {
            if(closeBook==true){

            bookFaceLeft.Rotate(new Vector3(0, 0, Time.deltaTime * bookOpenSpeed), Space.Self);
            bookFaceRight.Rotate(new Vector3(0, 0, -Time.deltaTime * bookOpenSpeed), Space.Self);
            gift.transform.localScale -= scaleFactor;

            float angle1 = Quaternion.Angle(bookFaceRight.rotation, targetRotation);

            Debug.Log("angle1 "+  angle1);
            
            if(angle1<0.1f){

                Debug.Log("reach traget analge");
                closeBook=false;
                openBook=true;
                
            }

           



            }

              
        }
        
    }
}
