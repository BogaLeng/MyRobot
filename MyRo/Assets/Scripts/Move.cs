using UnityEngine;

public class Move : MonoBehaviour
{
 
    public float horizontalinput;//水平参数
    public float Verticalinput;//垂直参数
    public float speed=6.0f;//声明一个参数，没有规定
    private Rigidbody rb;
    private Vector3 tem,forward,right;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //在update中书写
    void FixedUpdate()
    {
        horizontalinput = -Input.GetAxis("Horizontal");
        //AD方向控制
        Verticalinput = -Input.GetAxis("Vertical");
        rb.velocity = new Vector3(0,0,0);
        if (horizontalinput != 0)
        {
            right = transform.right;
            tem = new Vector3(right.x, 0,right.z);
            rb.velocity = horizontalinput*speed*tem;
        }
        if (Verticalinput != 0)
        {
            forward = transform.forward;
            tem = new Vector3(forward.x, 0, forward.z);
            rb.velocity = Verticalinput*speed*tem;
        }
    }
}
