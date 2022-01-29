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
        if (practice.activeSelf)
            practice.SetActive(false);

        if (theory.activeSelf)
            theory.SetActive(false);

        main.SetActive(true);
    }
}
