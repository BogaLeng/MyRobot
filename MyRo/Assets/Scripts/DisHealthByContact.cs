using UnityEngine;
using UnityEngine.UI;
public class DisHealthByContact : MonoBehaviour
{
    public Slider HP;
    public void OnTriggerEnter()
    {
        if(HP.value>0&&!AutoAttack.isInvincibility)
            HP.value -= 0.1f;
    }
}
