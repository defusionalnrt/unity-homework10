using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUI : MonoBehaviour
{

    public Slider slider;
    public float maxHp;
    public float delta;
    // Start is called before the first frame update
    void Start() {
        slider.maxValue = maxHp;
        slider.minValue = 0.0f;
        slider.value = slider.maxValue;
        
    }
    // Update is called once per frame
    void Update() {

        slider.direction = Slider.Direction.LeftToRight;
        slider.transform.rotation = Camera.main.transform.rotation;
        
        if(slider.value <= 0.3 * slider.maxValue){
            slider.fillRect.transform.GetComponent<Image>().color = Color.red;
        }
        else if(slider.value <= 0.6 * slider.maxValue){
            slider.fillRect.transform.GetComponent<Image>().color = Color.yellow;
        }
        else{
            slider.fillRect.transform.GetComponent<Image>().color = Color.green;
        }
    }

    public void getHurt(){
        slider.value -= delta;
        if(slider.value <= 0){
            slider.value = 0;
        }
    }

    public void getHeal(){
        slider.value += delta;
        if(slider.value >= slider.maxValue){
            slider.value = slider.maxValue;
        }
        
    }
}
