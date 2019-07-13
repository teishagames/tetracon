using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [HideInInspector]public bool buttonIsPressed=false;
    [SerializeField] float sizeUpValue;
    [SerializeField] Color notActiveColor,activeColor;
    [SerializeField] bool isHeadButton=false;


    Color startColor;
    byte colorByte=5;
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        
        if(isHeadButton){
            spriteRenderer.color=activeColor;
        }else{
            spriteRenderer.color=notActiveColor;
        }
        Physics2D.queriesStartInColliders=false; // Ignore self Collider for RayCast
       
    } 

    
    void OnMouseDown()
    {
        if(!buttonIsPressed){
        
         spriteRenderer.color=newButtonColor();   
         buttonIsPressed=true;   
         transform.localScale=new Vector2(transform.localScale.x+sizeUpValue,transform.localScale.y+sizeUpValue);   
        }
    }
   
    void OnMouseUp()
    {
    transform.localScale=new Vector2(transform.localScale.x-sizeUpValue,transform.localScale.y-sizeUpValue);
    }

    private Color newButtonColor(){
        if(StepLogic.stepLogicInstance.StepFirstPlayer){
            
          return  StepLogic.stepLogicInstance.playerFirstColor;


        }else{

        return StepLogic.stepLogicInstance.playerSecondColor;
        
        }
    }
  
   void FixedUpdate()
   {
       if(buttonIsPressed){
        Debug.DrawRay(transform.position,transform.right*0.6f,Color.blue);
        Debug.DrawRay(transform.position,transform.up*0.6f,Color.blue);
        Debug.DrawRay(transform.position,-transform.up*0.6f,Color.blue);
        Debug.DrawRay(transform.position,-transform.right*0.6f,Color.blue);
        
        RaycastHit2D hitRight=Physics2D.Raycast(transform.position,transform.right,5f);
        RaycastHit2D hitUp=Physics2D.Raycast(transform.position,transform.up,5f);  
        RaycastHit2D hitDown=Physics2D.Raycast(transform.position,-transform.up,5f);
        RaycastHit2D hitLeft=Physics2D.Raycast(transform.position,-transform.right,5f);

             if(hitRight.collider){
                 if(!hitRight.collider.gameObject.GetComponent<ButtonSettings>().buttonIsPressed){
                     hitRight.collider.gameObject.GetComponent<ButtonSettings>().spriteRenderer.color=activeColor;
                 }
        
             }

            
            if(hitUp.collider){
                 if(!hitUp.collider.gameObject.GetComponent<ButtonSettings>().buttonIsPressed){
                     hitUp.collider.gameObject.GetComponent<ButtonSettings>().spriteRenderer.color=activeColor;
                 }
            }
             if(hitDown.collider){
                 if(!hitDown.collider.gameObject.GetComponent<ButtonSettings>().buttonIsPressed){
                     hitDown.collider.gameObject.GetComponent<ButtonSettings>().spriteRenderer.color=activeColor;
                 }     
             }
              if(hitLeft.collider){
                 if(!hitLeft.collider.gameObject.GetComponent<ButtonSettings>().buttonIsPressed){
                     hitLeft.collider.gameObject.GetComponent<ButtonSettings>().spriteRenderer.color=activeColor;
                 }
              }
        
     }
   }
}
