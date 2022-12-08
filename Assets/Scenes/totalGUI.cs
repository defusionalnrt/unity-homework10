using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalGUI : MonoBehaviour
{
    public IMGUI hpBar1;
    public UGUI hpBar2;
    
    
    // Start is called before the first frame update
    void Start(){
        Debug.Log("start");
        gameObject.AddComponent<IMGUI>();
        hpBar1 = singleton<IMGUI>.Instance;
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnGUI(){
        if(GUI.Button(new Rect(0.7f * Screen.width, 180, 150, 35),"IMGUI-掉血")){
            hpBar1.getHurt();
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 140, 150, 35),"IMGUI-回血")){
            hpBar1.getHeal();
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 100, 150, 35),"UGUI-掉血")){
            hpBar2.getHurt();
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 60, 150, 35),"UGUI-回血")){
            hpBar2.getHeal();
        }
    }
}
