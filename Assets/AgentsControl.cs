using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsControl : MonoBehaviour
{
    public GameObject s;
    public GameObject[] CarAi = new GameObject[25];

    public int conta = 0;

    public bool stop;

    void Start()
    {
        for(int i = 0;i<25;i++)
        {
          CarAi[i] = Instantiate(s,transform.position,transform.rotation);
        }
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
     
       if(conta == 25){stop = true;}
       
       //buble();
       if(stop)
       {
          buble();
          print("troia");
         for(int i = 10;i<25;i++)
          {
            for(int j = 0;j<5;j++)
            {
              
              float[] Pr = new float[4];
              int l = Random.Range(0,10);
              int p = Random.Range(0,10);
              int m = Random.Range(0,5);
              if(l == p) {p = (p+1)%10;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().IL[j,z];}
              for(int z = m;z<4;z++){Pr[z] = CarAi[p].GetComponent<Movement>().IL[j,z];}
              for(int z = 0;z<4;z++)
                {
                  CarAi[i].GetComponent<Movement>().IL[j,z] = Pr[z];
                }
              int mut = Random.Range(0,4);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<4;j++)
            {
              
              float[] Pr = new float[3];
              int l = Random.Range(0,10);
              int p = Random.Range(0,10);
              int m = Random.Range(0,4);
              if(l == p) {p = (p+1)%10;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H1L[j,z];}
              for(int z = m;z<3;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H1L[j,z];}
              for(int z = 0;z<3;z++)
                {
                  CarAi[i].GetComponent<Movement>().H1L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,3);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<3;j++)
            {
              
              float[] Pr = new float[2];
              int l = Random.Range(0,10);
              int p = Random.Range(0,10);
              int m = Random.Range(0,3);
              if(l == p) {p = (p+1)%10;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H2L[j,z];}
              for(int z = m;z<2;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H2L[j,z];}
              for(int z = 0;z<2;z++)
                {
                  CarAi[i].GetComponent<Movement>().H2L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,2);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }

          }
          for(int i = 5;i<10;i++)
          {
            for(int j = 0;j<5;j++)
            {
              
              float[] Pr = new float[4];
              int l = Random.Range(0,5);
              int p = Random.Range(0,5);
              int m = Random.Range(0,5);
              if(l == p) {p = (p+1)%5;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().IL[j,z];}
              for(int z = m;z<4;z++){Pr[z] = CarAi[p].GetComponent<Movement>().IL[j,z];}
              for(int z = 0;z<4;z++)
                {
                  CarAi[i].GetComponent<Movement>().IL[j,z] = Pr[z];
                }
              int mut = Random.Range(0,4);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<4;j++)
            {
              
              float[] Pr = new float[3];
              int l = Random.Range(0,5);
              int p = Random.Range(0,5);
              int m = Random.Range(0,4);
              if(l == p) {p = (p+1)%5;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H1L[j,z];}
              for(int z = m;z<3;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H1L[j,z];}
              for(int z = 0;z<3;z++)
                {
                  CarAi[i].GetComponent<Movement>().H1L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,3);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<3;j++)
            {
              
              float[] Pr = new float[2];
              int l = Random.Range(0,5);
              int p = Random.Range(0,5);
              int m = Random.Range(0,3);
              if(l == p) {p = (p+1)%5;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H2L[j,z];}
              for(int z = m;z<2;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H2L[j,z];}
              for(int z = 0;z<2;z++)
                {
                  CarAi[i].GetComponent<Movement>().H2L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,2);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }

          }
          for(int i = 2;i<5;i++)
          {
            for(int j = 0;j<5;j++)
            {
              
              float[] Pr = new float[4];
              int l = Random.Range(0,2);
              int p = Random.Range(0,2);
              int m = Random.Range(0,5);
              if(l == p) {p = (p+1)%2;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().IL[j,z];}
              for(int z = m;z<4;z++){Pr[z] = CarAi[p].GetComponent<Movement>().IL[j,z];}
              for(int z = 0;z<4;z++)
                {
                  CarAi[i].GetComponent<Movement>().IL[j,z] = Pr[z];
                }
              int mut = Random.Range(0,4);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<4;j++)
            {
              
              float[] Pr = new float[3];
              int l = Random.Range(0,2);
              int p = Random.Range(0,2);
              int m = Random.Range(0,4);
              if(l == p) {p = (p+1)%2;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H1L[j,z];}
              for(int z = m;z<3;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H1L[j,z];}
              for(int z = 0;z<3;z++)
                {
                  CarAi[i].GetComponent<Movement>().H1L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,3);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }
            for(int j = 0;j<3;j++)
            {
              
              float[] Pr = new float[2];
              int l = Random.Range(0,2);
              int p = Random.Range(0,2);
              int m = Random.Range(0,3);
              if(l == p) {p = (p+1)%2;}
              for(int z = 0;z<m;z++){Pr[z] = CarAi[l].GetComponent<Movement>().H2L[j,z];}
              for(int z = m;z<2;z++){Pr[z] = CarAi[p].GetComponent<Movement>().H2L[j,z];}
              for(int z = 0;z<2;z++)
                {
                  CarAi[i].GetComponent<Movement>().H2L[j,z] = Pr[z];
                }
              int mut = Random.Range(0,2);
              float mut1 = Random.Range(-10f,10f);
              CarAi[i].GetComponent<Movement>().IL[j,mut] = mut1;
            }

          }
          stop = false;
          for(int j = 0;j<25;j++)
          {
            CarAi[j].GetComponent<Movement>().play = true;
            CarAi[j].transform.position = transform.position;
            CarAi[j].transform.rotation = transform.rotation;
            CarAi[j].GetComponent<Movement>().distance = 0;
          }
          conta = 0;
       }
    }
    void buble()
    {
      for(int i = 0;i<25;i++)
      {
        for(int j = 1;j<25;j++)
        {
           if(CarAi[j].GetComponent<Movement>().distance>CarAi[j-1].GetComponent<Movement>().distance)
           {
             GameObject prev = CarAi[j-1];
             GameObject succ = CarAi[j];
             CarAi[j] = prev;
             CarAi[j-1] = succ;
           }
        }
      }
    }
    
}
