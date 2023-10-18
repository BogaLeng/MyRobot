using UnityEngine;
using UnityEngine.UI;
public class DisHealthByContact : MonoBehaviour
{
    public Slider HP;
    public void OnTriggerEnter()
    {
        HP.value -= 0.1f;
    }
}
