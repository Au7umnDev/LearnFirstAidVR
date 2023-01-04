using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleTest_Check : MonoBehaviour
{
    public GameObject completedMark;
    public GameObject practiceModule;
    public GameObject mainModule;
    public GameObject simulationPage;

    public void CheckTest()
    {
        if(completedMark.activeSelf == true)
        {
            practiceModule.SetActive(false);
            mainModule.SetActive(true);
            simulationPage.SetActive(true);
            return;
        }
        else
        {
            return;
        }
    }
}
