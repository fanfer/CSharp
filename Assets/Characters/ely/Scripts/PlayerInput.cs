using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

[RequireComponent(typeof(Character))]
public class PlayerInput : MonoBehaviour
{
    //调节移动的速度、距离
    private float moveSmoothingFacter = 0.01f;

    private Character character;
    void Start()
    {
        character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

        //获得输入并传递给角色进行移动
        character.AddMovementInput(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}
