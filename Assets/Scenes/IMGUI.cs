using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour
{
    public float maxHp;
    public float currentHp;
    public float delta;
    // Start is called before the first frame update
    void Start(){
        maxHp = 400.0f;
        currentHp = maxHp;
        delta = 30.0f;
    }

    // Update is called once per frame
    void Update(){
        
    }
    public void getHurt(){
        currentHp = currentHp - delta;
        if(currentHp < 0.0f){
            currentHp = 0.0f;
        }
    }
    public void getHeal(){
        currentHp = currentHp + delta;
        if(currentHp >= maxHp){
            currentHp = maxHp;
        }
    }
    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    void OnGUI(){
        GUIStyle healthTextStyle = new GUIStyle();
        healthTextStyle.fontSize = 20;
        healthTextStyle.alignment = TextAnchor.MiddleCenter;
        if(currentHp < maxHp * 0.2){
            GUI.color = Color.red;
        }else if(currentHp < maxHp * 0.5){
            GUI.color = Color.yellow;
        }else{
            GUI.color = Color.green;
        }
        GUI.HorizontalScrollbar(new Rect(30, 30, Screen.width - 100, 30), 0.0F, currentHp, 0.0F, maxHp);
        GUI.Label(new Rect(30, 50, Screen.width - 60, 20), currentHp.ToString() + " / " + maxHp.ToString(), healthTextStyle);
    }
}
