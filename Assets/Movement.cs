using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D a;
    //public float sped = 10000.5f;
    private float vx = 0;
    
    public GameObject AC;
    public float distance = 0;
    public float[,] IL = new float[5,4];
    public float[,] H1L = new float[4,3];
    public float[,] H2L = new float[3,2];
    public float[] IV = new float[5];
    public float[] L1V = new float[4];
    public float[] L2V = new float[3];
    public float[] OL = new float[2]; 
    public bool play = false;
    public Vector2 lastpos;
    void Start()
    {
        lastpos = transform.position;
        a = GetComponent<Rigidbody2D>();
        for(int i = 0;i<5;i++)
        {
           for(int j = 0;j<4;j++)
           {
             float rand = Random.Range(-10f,10f);
             IL[i,j] = rand; 
           }
        }
         for(int i = 0;i<4;i++)
        {
           for(int j = 0;j<3;j++)
           {
             float rand = Random.Range(-10f,10f);
             H1L[i,j] = rand; 
           }
        }
         for(int i = 0;i<3;i++)
        {
           for(int j = 0;j<2;j++)
           {
             float rand = Random.Range(-10f,10f);
             H2L[i,j] = rand; 
           }
        }
    }
    void FixedUpdate()
    {
       if(play)
      {
        float speed = 2f;
        float cos = 0.2f;
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        //a.rotation-=3*hor;
        //vx+=ver*cos;
        if(vx>6) vx = 6;
        if(vx<-6) vx = -6;
        //for(int i = 0;)
        float RayF1 = (a.rotation+90+45) * Mathf.Deg2Rad;
        float RayF2 = (a.rotation+90-45) * Mathf.Deg2Rad;
        float RayF3 = (a.rotation+90+90) * Mathf.Deg2Rad;
        float RayF4 = (a.rotation+90-90) * Mathf.Deg2Rad;
        //transform.Translate(new Vector2(0,vx) * speed * Time.deltaTime);
        RaycastHit2D[] Hit = new RaycastHit2D[5];
        Hit[0] = Physics2D.Raycast(transform.position,transform.up,20);
        Hit[1] = Physics2D.Raycast(transform.position,new Vector2(Mathf.Cos(RayF1),Mathf.Sin(RayF1)),20);
        Hit[2] = Physics2D.Raycast(transform.position,new Vector2(Mathf.Cos(RayF2),Mathf.Sin(RayF2)),20);
        Hit[3] = Physics2D.Raycast(transform.position,new Vector2(Mathf.Cos(RayF3),Mathf.Sin(RayF3)),20);
        Hit[4] = Physics2D.Raycast(transform.position,new Vector2(Mathf.Cos(RayF4),Mathf.Sin(RayF4)),20);
        //print(Hit[0].distance);
       for(int i = 0;i<5;i++)
         {
           if(Hit[i].collider != null)
            {
              //print("ciaotf");
              Debug.DrawLine(transform.position,Hit[i].point,Color.red);
            }
         }
       for(int i = 0;i<5;i++) IV[i] = Hit[i].distance/20;
       //calculate the layer in the neural network
       for(int i = 0;i<4;i++)
       {
         float a = 0;
         for(int j = 0;j<5;j++)
         {
            a+=IV[j]*IL[j,i];
         }
         float b = sigmoind(a);
         L1V[i] = b;
       }
       for(int i = 0;i<3;i++)
       {
         float a = 0;
         for(int j = 0;j<4;j++)
         {
            a+=L1V[j]*H1L[j,i];
         }
         float b = sigmoind(a);
         L2V[i] = b;
       }
      for(int i = 0;i<2;i++)
       {
         float a = 0;
         for(int j = 0;j<3;j++)
         {
            a+=L2V[j]*H2L[j,i];
         }
         float b = Tanh(a);
         OL[i] = b;
       }
       //print(OL[1]);
       a.rotation-=4*OL[1];
       vx+=OL[0]*2;
       transform.Translate(new Vector2(0,vx) * speed * Time.deltaTime);
       distance= Mathf.Sqrt(transform.position.x*transform.position.x+transform.position.y*transform.position.y);
       lastpos = transform.position;
       //print(distance);
    }
    }

    void OnCollisionEnter2D(Collision2D other) {
          play = false;
          AC.GetComponent<AgentsControl>().conta+=1;
          
    }
      
    float sigmoind(float x)
    {
        return 1/(1+Mathf.Exp(-x));
    }
    float Tanh (float f)
    {
        return (float)System.Math.Tanh((double)f);
    }
    }




