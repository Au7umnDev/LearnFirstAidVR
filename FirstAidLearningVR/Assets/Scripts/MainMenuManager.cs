using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject main;
    public GameObject theory;
    public GameObject practice;

    public void OpenTheoryMenu()
    {
        main.SetActive(false);
        theory.SetActive(true);
    }
    public void OpenPracticeMenu()
    {
        main.SetActive(false);
        practice.SetActive(true);
    }
    public void OpenMainMenu()
    {
        if (practice.activeSelf == true)
            practice.SetActive(false);

        if (theory.activeSelf == true)
            theory.SetActive(false);

        main.SetActive(true);
    }
}
