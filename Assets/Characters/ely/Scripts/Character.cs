using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    
    private Vector3 velocity;

    public CameraController cameraController;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }


    public void AddMovementInput(float forward, float right)
    {

        //ÏòÁ¿¼ÆËã
        Vector3 camFwd = cameraController.transform.forward;
        Vector3 camRight = cameraController.transform.right;
     
        // Debug.Log("camFwd : "+camFwd+"  "+"camRight : "+camRight);

        Vector3 translation = forward * camFwd;
        translation += right * camRight;
        
        translation.y=0;

        if (translation.magnitude>0)
        {
            velocity = translation;
        }
        else
        {
            velocity = Vector3.zero;
        }

       

        
    }

     public float getVelocity()
        {
        Debug.Log("velocity : " + velocity.magnitude);
        return velocity.magnitude;
        }

}
