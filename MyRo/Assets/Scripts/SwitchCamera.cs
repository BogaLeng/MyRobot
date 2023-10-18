using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject fCam;	//第一视角摄像机
    public GameObject tCam;	//第三人称摄像机
	
    bool flag=false;			//fCam启用为true
	
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //获取相机
        fCam=GameObject.Find("CameraP1");	//获取第一视角相机
        tCam=GameObject.Find("CameraP3");	//获取第三视角相机
        fCam.SetActive(false);		//禁用第一视角相机，第三视角作为主相机
    }

    private void Update()
    {
        //F作为切换触发
        //每按下一次发生切
        if(Input.GetKeyDown(KeyCode.F))
        {
            flag=!flag; //状态反转
            fCam.SetActive(flag);
            tCam.SetActive(!flag);	//两个相机状态互斥
        }
    }
}
