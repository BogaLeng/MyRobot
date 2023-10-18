using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveTo : MonoBehaviour
{
    #region 数据
    private float X;
    private float Y;
    public Rigidbody rb;
    public float MoveRate = 3;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        X += Input.GetAxis("Mouse X");
        Y += Input.GetAxis("Mouse Y");
        rb.transform.localEulerAngles = new Vector3(Y,X*MoveRate, 0);
    }
}
