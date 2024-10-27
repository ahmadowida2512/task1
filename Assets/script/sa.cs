using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
    
   
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
