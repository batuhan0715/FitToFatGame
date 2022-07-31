using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    public CaloriCounter caloriCount;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(CaloriCounter.caloriValue == 700)
        {
            StartCoroutine(Wait());
        }

        if(CaloriCounter.caloriValue > 700)
        {
            StartCoroutine(Waitwo());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        CaloriCounter.caloriValue = 0;
        SceneManager.LoadScene(1);
    }
    
    IEnumerator Waitwo()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        CaloriCounter.caloriValue = 0;
        SceneManager.LoadScene(2);
    }
    
}
