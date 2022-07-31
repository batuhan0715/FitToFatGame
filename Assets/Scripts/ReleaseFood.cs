using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseFood : MonoBehaviour
{
    bool isRealesed;
    
    void Start()
    {
        isRealesed = false;
    }

    
    void Update()
    {


        //Destroy();

        
    }


   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mouth" )
        {
            isRealesed = true;
           
            
        }
    }

    private void Destroy()
    {
        if (Input.GetMouseButtonUp(0) && isRealesed == true)
        {
            Destroy(gameObject);


        }
    }

}
