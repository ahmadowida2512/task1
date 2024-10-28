using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class sa : MonoBehaviour
{
      // Start is called before the first frame update
      void Start()
      {

            string[] words = { "Cat","Dog" , "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
     
            int RandomNumber=Random.Range(1,9);
             
                   string sayahh=words[RandomNumber];
            int i=0;
            while (i <13)
            {
                 int index=RandomNumber;
            // Debug.Log(words[index]);
             i++;
              Debug.Log(sayahh);
             if (sayahh==words[RandomNumber]){
                  Debug.Log("you are vary fune mannnnnnnnnnn");
                
                break;
             }
            }
          
           // Task2

                            int sayhh=0;


                     while (sayhh<21)
            {

             int RandomnNamber=Random.Range(1,21);
             Debug.Log(RandomnNamber);
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