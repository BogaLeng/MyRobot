using UnityEngine;
using UnityEngine.UI;
public class HealthControl : MonoBehaviour
{
    public Slider HP;
    void Start()
    {
        HP.value = 1.0f;
    }

    public void disHP()
    {
        HP.value -= 0.1f;
    }
}
