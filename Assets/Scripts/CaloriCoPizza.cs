using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CaloriCoPizza : MonoBehaviour
{
    TextMeshPro caloriee;
    public static float caloriValue;

    void Start()
    {
        caloriee = GetComponent<TextMeshPro>();

    }


    void Update()
    {
        caloriee.text = "" + caloriValue;

    }
}
