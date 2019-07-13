using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolOnObject : MonoBehaviour
{
    bool isPressed=false;

  
    void OnMouseDown()
    {
        if(!isPressed){
           isPressed=true;
           gameObject.GetComponent<SpriteRenderer>().color=newButtonColor();
    }
    }

    private Color newButtonColor(){
        Color buttonColor=new Color();
        
        if(StepLogic.stepLogicInstance.StepFirstPlayer){
             buttonColor=Color.blue;
        }else if(!StepLogic.stepLogicInstance.StepFirstPlayer){
             buttonColor=Color.red;
        }
        return buttonColor;

    }

}
