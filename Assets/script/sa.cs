using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class sa : MonoBehaviour
{
      // Start is called before the first frame update
     
         string sayahh;

      void Start()
      {

            string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };


            int i = 1;
            while (i <= 7)
            {
                  int RandomNumber = Random.Range(0, 10);
                  sayahh+=  words[RandomNumber]+",";
                  
                  i++;

                  //  if (sayahh==words[RandomNumber]){
                  //       Debug.Log("you are vary fune mannnnnnnnnnn");

                  //     break;
                  //  }
            }
            
Debug.Log(sayahh);
            // Task2

            //                 int sayhh=0;


            //          while (sayhh<21)
            // {

            //  int RandomnNamber=Random.Range(1,21);
            //  Debug.Log(RandomnNamber);
            //  sayhh++;
            //    if (sayhh == 5)

            // continue;



            //       else if (sayhh == 15){
            // Debug.Log("ya lahoyyyyyyyyyyyyyyyyyyyyyyyyyy");
            // break;



            //       };

            // }

      }

}