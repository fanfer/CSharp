using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

[RequireComponent(typeof(Character))]
public class PlayerInput : MonoBehaviour
{
    //�����ƶ����ٶȡ�����
    private float moveSmoothingFacter = 0.01f;

    private Character character;
    void Start()
    {
        character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

        //������벢���ݸ���ɫ�����ƶ�
        character.AddMovementInput(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}
