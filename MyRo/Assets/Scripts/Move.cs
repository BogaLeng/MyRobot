using UnityEngine;

public class Move : MonoBehaviour
{
 
    public float horizontalinput;//水平参数
    public float Verticalinput;//垂直参数
    public float speed=5.0f;//声明一个参数，没有规定
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //在update中书写
    void Update()
    {

        horizontalinput = -Input.GetAxis("Horizontal");
        //AD方向控制
        Verticalinput = -Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalinput * speed, 0.0f, Verticalinput * speed);
    }
}
