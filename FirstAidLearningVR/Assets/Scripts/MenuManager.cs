using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public List<GameObject> pages = new List<GameObject>();

    public Text pageCounter;

    public GameObject arrowPrevious;
    public GameObject arrowNext;

    public GameObject completedMark;

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

        if(arrowNext.activeSelf == false)
        {
            arrowNext.SetActive(true);
        }

        pages[pageIterator].SetActive(false);

        pageCounter.text = "Страница " + pageIterator + " из " + pages.Count;

        pageIterator--;

        if (pageIterator == 0)
        {
            arrowPrevious.SetActive(false);
        }

        pages[pageIterator].SetActive(true);
    }

    public void GoToNextPage()
    {
        if (pageIterator == pages.Count - 1)
        {
            return;
        }

        if (arrowPrevious.activeSelf == false)
        {
            arrowPrevious.SetActive(true);
        }

        pages[pageIterator].SetActive(false);

        pageIterator++;

        pages[pageIterator].SetActive(true);

        pageIterator++;
        pageCounter.text = "Страница " + pageIterator + " из " + pages.Count;
        pageIterator--;

        if (pageIterator == pages.Count - 1)
        {
            arrowNext.SetActive(false);
            completedMark.SetActive(true);
        }
    }

    public void ClosePage()
    {
        if(pageIterator != 0)
        {
            pages[pageIterator].SetActive(false);

            pageIterator = 1;
            pageCounter.text = "Страница " + pageIterator + " из " + pages.Count;
            pageIterator--;

            pages[pageIterator].SetActive(true);

            arrowPrevious.SetActive(false);
            arrowNext.SetActive(true);
        }
    }
}