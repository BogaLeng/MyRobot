using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject fCam;	//第一视角摄像机
    public GameObject tCam;	//第三人称摄像机
    public GameObject pCam; //旁观视角摄像机
    public static bool flag=false,pFlag=false;			//fCam启用则为true
	
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;//指针锁定
        //获取相机
        fCam=GameObject.Find("CameraP1");	//获取第一视角相机
        tCam=GameObject.Find("CameraP3");  //获取第三视角相机
        pCam = GameObject.Find("Camera");
        fCam.SetActive(false); //禁用第一视角相机，第三视角作为主相机
        pCam.SetActive(false);//禁用旁观相机
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

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (pFlag)
            {
                pFlag = false;
                pCam.SetActive(false);
                tCam.SetActive(true);
            }
            else
            {
                pFlag = true;
                pCam.SetActive(true); //旁观相机启动！
                fCam.SetActive(false);
                tCam.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerBeingAttacked.HP = 100;
            shoot.heat = 1;
            AutoAttack.HP = 100f;
            AutoAttack.isInvincibility = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
