using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepLogic : MonoBehaviour
{
    public static StepLogic stepLogicInstance;
    Grid grid;
    [HideInInspector]public bool StepFirstPlayer=true;
    public Color playerFirstColor;
    public Color playerSecondColor;
    

    private void Awake()
    {
        if(ReferenceEquals(stepLogicInstance,null)){

            stepLogicInstance=this;
        }else{
            return;
        }
       
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
           ChangeStepBool();
        }
    }

   private bool  ChangeStepBool() {
        return StepFirstPlayer =! StepFirstPlayer;
        
    }
    private void DebugBool(){
        ChangeStepBool();
        if(StepFirstPlayer){
            Debug.Log(true);
        }else{
            Debug.Log(false);
        }

    }
}
