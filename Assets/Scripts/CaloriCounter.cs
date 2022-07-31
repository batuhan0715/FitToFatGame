using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CaloriCounter : MonoBehaviour
{
    
    TextMeshPro caloriee;
    public static float caloriValue = 0;
    
    void Start()
    {
        caloriee = GetComponent<TextMeshPro>();
        
    }

    
    void Update()
    {
        caloriee.text = "" + caloriValue;
        
    }

    
}
