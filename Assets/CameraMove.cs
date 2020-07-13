using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject a;
    public new GameObject[] k = new GameObject[25];
    public bool CarMove;
    void Start()
    {
        Invoke("GetCar", 2);
        CarMove = false;
    }

    // Update is called once per frame
    void Update()
    {   
        float sped = 1.5f;
        if(CarMove)
        {
        int a = 0 ;
        float distance = 0;
        for(int i = 0;i<25;i++)
        {
            if(k[i].GetComponent<Movement>().distance>distance)
            {
                distance = k[i].GetComponent<Movement>().distance;
                a = i;
            }
        }
        transform.position = new Vector3(k[a].transform.position.x+6,k[a].transform.position.y,-10);
        //buble();
        //print(a);
        }
        if(!CarMove)
        {
          float hor = Input.GetAxis("Horizontal");
          float ver = Input.GetAxis("Vertical");
          Vector3 KI = new Vector3(hor*sped,ver*sped,0);
          transform.position = transform.position+ KI;
          if(Input.GetKeyDown(KeyCode.S))
             {
               CarMove = true;
               for(int i = 0;i<25;i++)
               {
                 k[i].GetComponent<Movement>().play = true;
               }
             }
        }
    }
    void GetCar()
    {
       GameObject[] l = new GameObject[25];
       k = a.GetComponent<AgentsControl>().CarAi;
    }
    void buble()
    {
      for(int i = 0;i<25;i++)
      {
        for(int j = 1;j<25;j++)
        {
           if(k[j].GetComponent<Movement>().distance>k[j-1].GetComponent<Movement>().distance)
           {
             GameObject prev = k[j-1];
             GameObject succ = k[j];
             k[j] = prev;
             k[j-1]= succ;
           }
        }
      }
    }
}
