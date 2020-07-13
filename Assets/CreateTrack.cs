using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateTrack : MonoBehaviour
{
     public GameObject s;
     GameObject y2;
     private bool cons;
     private int conta = 0;
     private int o;
     private Vector3 lastPos;
     private bool dow;
     void Start() {
         cons = true;
         lastPos = new Vector3(-10,-10,0);
         dow = true;

     }
    void FixedUpdate() {
          if(Input.GetKeyDown(KeyCode.A))
          {
              cons = !cons;
              if(!cons){conta = 0;} 
          }
         if(cons == true)
         {
              
              if(Input.GetMouseButton(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition)!=lastPos && conta == 0)
                {
                   lastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                   Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                   mousePos.z = 0; 
                   y2 = Instantiate(s,transform.position,transform.rotation);
                   conta = 1;
                   print(mousePos);
                }
               if(conta == 1)
                {
                    float speed = 5f;
                    float mid = 0.5f;
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector3 mousePos1 =  mousePos+lastPos;
                    Vector3 mousePos2 = mousePos-lastPos;
                    float y1 = Mathf.Sqrt(mousePos2.x * mousePos2.x + mousePos2.y * mousePos2.y); 
                    y2.transform.position = new Vector2(mousePos1.x,mousePos1.y)*mid;
                    y2.transform.localScale = new Vector2(0.5f,y1);
                    Vector2 direction = mousePos-y2.transform.position;
                    float angle = Mathf.Atan2(direction.y,direction.x)* Mathf.Rad2Deg+90;
                    //Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                    y2.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                    if(Input.GetMouseButton(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition)!=lastPos)
                    {
                        conta = 0;
                    }
                }

                

                

         }

     }
        
     }
            


