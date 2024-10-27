using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
                            //Task1
   string[] words={"Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird"};
   string len= words.Length.ToString();
//  Debug.Log(len);
//  int sayahh=0;
while (sayahh < words.Length){
Debug.Log(words[sayahh]);
sayahh++;


      }
                    //Task2
   
                int sayhh=0;
        
   
         while (sayhh<21)
{

 int Randomn=Random.Range(1,21);
 Debug.Log(Randomn);
 sayhh++;
   if (sayhh == 5)

continue;

   
   
      else if (sayhh == 15){
Debug.Log("ya lahoyyyyyyyyyyyyyyyyyyyyyyyyyy");
break;



      };

}

}  
   
}