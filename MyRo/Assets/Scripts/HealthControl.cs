using UnityEngine;
using UnityEngine.UI;
public class HealthControl : MonoBehaviour
{
    public Slider HP;
    public AudioClip explodeSound;
    private bool isExplode=false;
    public float nextRecover, recoverRate = 5.0f;
    void Start()
    {
        HP.value = 1.0f;
        nextRecover = recoverRate + Time.time;
        //Debug.Log(HP.transform.position);
    }

    void FixedUpdate()
    {
        if (AutoAttack.isInvincibility)
            HP.transform.position=new Vector3(-3.6f,-10f,-27.9f);
        else
            HP.transform.position=new Vector3(-3.6f,8.0f,-27.9f);
        if (HP.value == 0.0f&&!isExplode)
        {
            isExplode = true;
            AudioManager.instance.AudioPlay(explodeSound);
            GameObject home=GameObject.Find("Home");
            home.transform.position = new Vector3(-3.6f,-20,-27.9f);
            HP.transform.position=new Vector3(-3.6f,-10f,-27.9f);
        }

        if (Time.time > nextRecover)
        {
            nextRecover = Time.time + recoverRate;
            HP.value += 0.1f;
        }
    }
    public void disHP()
    {
        HP.value -= 0.1f;
    }
    void DestroyWithChildren(GameObject obj)  
    {  
        Destroy(obj);
  
        for(int i = 0; i < obj.transform.childCount; i++)  
        {  
            Transform child = obj.transform.GetChild(i);  
            DestroyWithChildren(child.gameObject);  
        }  
    }
}
