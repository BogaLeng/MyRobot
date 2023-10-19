using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public static bool ifMove=true;
    public GameObject bulletPrefab;

    public float BulletSpeed = 30.0f,nextFire,fireRate=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        nextFire = fireRate + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        //声明一个Ray结构体，用于存储该射线的发射点，方向
        RaycastHit hitInfo;
        //声明一个RaycastHit结构体，存储碰撞信息
        if (Physics.Raycast(ray, out hitInfo))
        {
            Debug.DrawLine(transform.position,hitInfo.point,Color.red);            
            //这里使用了RaycastHit结构体中的collider属性
            //因为hitInfo是一个结构体类型，其collider属性用于存储射线检测到的碰撞器。
            //通过collider.gameObject.name，来获取该碰撞器的游戏对象的名字。
            ifMove = false;//是否继续移动
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet=Instantiate(bulletPrefab, transform.position, transform.rotation); //生成预制体
                bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward * BulletSpeed;
                Destroy(bullet, 2);
            }
        }
        else
            ifMove = true;
    }
}
