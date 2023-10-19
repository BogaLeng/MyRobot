using UnityEngine;
using UnityEngine.UI;

public class UILogic : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("准星的长度")]
    public float width;
    [Header("准星的高度")]
    public float height;
    [Header("上下（左右）两条准星之间的距离")]
    public float distance;
    [Header("准星背景图")]
    public Texture2D crosshairTexture;

    public float ScHeight, ScWidth;
    private GUIStyle lineStyle;     //  GUI自定义参数
    private Texture tex;            //  准星背景辅助参数
 
    private void Start()
    {
        lineStyle = new GUIStyle();                         //  游戏开始实例化背景图
        lineStyle.normal.background = crosshairTexture; //  将背景图默认背景设为准星背景
        ScWidth = Screen.width / 2.0f;
    }
 
    private void OnGUI()
    {
        if (SwitchCamera.flag)
            ScHeight = Screen.height / 2.0f-25;
        else
            ScHeight = Screen.height / 2.0f-155;
        //  左准星
        GUI.Box(new Rect(ScWidth - distance / 2 - width, ScHeight- height / 2, width, height), tex, lineStyle);
        //  右准星
        GUI.Box(new Rect(ScWidth + distance / 2 , ScHeight - height / 2, width, height), tex, lineStyle);
        //  上准星
        GUI.Box(new Rect(ScWidth - height / 2, ScHeight - distance / 2 - width, height, width), tex, lineStyle);
        //  下准星
        GUI.Box(new Rect(ScWidth - height / 2, ScHeight + distance / 2, height, width), tex,lineStyle);
        showHPandHeat();
    }

    void showHPandHeat()
    {
        GUIStyle style = new GUIStyle(); 
        Rect rect = new Rect(10, 10, 200, 20);  
  
        string text = string.Concat("Muzzle heat is ", shoot.heat);
        text = string.Concat(text, "\nHP: ");
        text = string.Concat(text, PlayerBeingAttacked.HP);
        style.alignment = TextAnchor.UpperLeft;  
        float labelWidth = style.fixedWidth;  
        float labelHeight = style.fixedHeight;  
  
        style.normal.textColor = Color.red;  
        style.fontSize = 30;  
        Rect textRect = new Rect(rect.x, rect.y + (rect.height - labelHeight) / 2f, labelWidth, labelHeight);  
        GUI.Label(textRect, text, style); 
    }
}
