using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public List<GameObject> completedMarks = new List<GameObject>();

    public int completedModules;

    public Text currentTasks;

    public void CountProgress()
    {
        completedModules = 0;

        foreach (var completedMark in completedMarks)
        {
            if(completedMark.activeSelf == true)
            {
                completedModules++;
            }
        }

        currentTasks.text = completedModules.ToString();
    }

    public void ResetProgress()
    {
        completedModules = 0;
        currentTasks.text = completedModules.ToString();

        foreach (var completedMark in completedMarks)
        {
            completedMark.SetActive(false);
        }
    }
}
