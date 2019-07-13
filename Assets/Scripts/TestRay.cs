using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRay : MonoBehaviour
{
    
/// <summary>
/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
void Start()
{
Physics2D.queriesStartInColliders=false;

}
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        //Vector2 pos=new Vector2(transform.position.x+1,transform.position.y);
        Debug.DrawRay(transform.position,transform.right*5f,Color.blue);
        RaycastHit2D hit=Physics2D.Raycast(transform.position,transform.right,5f);
             
             if(hit.collider){
                Debug.Log("touch"+hit.collider.name);
        
             }else{
                
                Debug.Log("not");
        }
        
    }
    void OnMouseDown()
    {
        

    }
 
}