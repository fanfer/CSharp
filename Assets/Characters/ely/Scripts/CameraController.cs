using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //������ת�ٶȵĲ���
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

        //���¿�
        camRotation.x += Input.GetAxis("Mouse Y")* cameraSmoothingFactor*(-1); 
        
        //���ҿ�
        camRotation.y += Input.GetAxis("Mouse X") * cameraSmoothingFactor;

        //�������ĽǶ�
        camRotation.x = Mathf.Clamp(camRotation.x, lookUpMin, lookUpMax);

        //ŷ������ʽ����ת��
        transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);
       
    }
}
