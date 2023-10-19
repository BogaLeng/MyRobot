using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    public Rigidbody rb;
    public static float HP=100.0f;//血量
    public static bool isInvincibility = true;
    public bool movingRight = true;
    public float speed = 5.0f;

    public AudioClip explodeSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (!AutoShoot.ifMove)
            return;
        if(movingRight)
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
            if (transform.position.z<=-18)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(speed * Time.deltaTime,0,0);
            //左移结束，右移开始，设置状态为true
            if (transform.position.z>=0)
            {
                movingRight = true;
            }
        }
    }

    void OnTriggerEnter()
    {
        //Debug.Log(HP);
        if(HP>0)
            HP -= 10.0f;
        if (HP == 0 && isInvincibility)
        {
            isInvincibility = false;
            AudioManager.instance.AudioPlay(explodeSound);
            GameObject tem=GameObject.Find("Sentry");
            tem.transform.position = new Vector3(0, -30, 0);
            //DestroyWithChildren(GameObject.Find("Sentry"));
        }
    }
    
}
