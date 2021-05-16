using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //控制旋转速度的参数
    public float cameraSmoothingFactor = 0.05f;

    public float lookUpMax = 45;
    public float lookUpMin = -45;

    private Quaternion camRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Mouse X") + " : " + Input.GetAxis("Mouse Y"));

        //上下看
        camRotation.x += Input.GetAxis("Mouse Y")* cameraSmoothingFactor*(-1); 
        
        //左右看
        camRotation.y += Input.GetAxis("Mouse X") * cameraSmoothingFactor;

        //设置最大的角度
        camRotation.x = Mathf.Clamp(camRotation.x, lookUpMin, lookUpMax);

        //欧拉数公式进行转化
        transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);
       
    }
}
