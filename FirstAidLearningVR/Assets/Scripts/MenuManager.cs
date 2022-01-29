using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public List<GameObject> pages = new List<GameObject>();

    public Text pageCounter;

    private int pageIterator;

    private void Start()
    {
        pageIterator = 0;
    }

    public void GoToPreviousPage()
    {
        if (pageIterator == 0)
        {
            return;
        }

        pages[pageIterator].SetActive(false);

        pageCounter.text = "Страница " + pageIterator + " из 3";

        pageIterator--;

        pages[pageIterator].SetActive(true);
    }

    public void GoToNextPage()
    {
        if (pageIterator == 2)
        {
            return;
        }

        pages[pageIterator].SetActive(false);

        pageIterator++;

        pageIterator++;
        pageCounter.text = "Страница " + pageIterator + " из 3";
        pageIterator--;

        pages[pageIterator].SetActive(true);
    }

}