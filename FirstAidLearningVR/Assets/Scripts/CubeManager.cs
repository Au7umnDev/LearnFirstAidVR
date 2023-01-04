using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject practiceModules;
    public GameObject practiceList;
    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thisPage;
    public GameObject rightRayInteractor;
    public GameObject defaultMannequin;

    public Collider firstCollider;
    public Collider secondCollider;
    public MeshRenderer meshRenderer;

    public bool checkIfCubeIsEntered = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (practiceModules.activeSelf)
        {
            if (collision.gameObject.tag == "CubeCheck")
            {
                if (!checkIfCubeIsEntered)
                {
                    StartCoroutine(firstCubeTouch());
                }
                if (checkIfCubeIsEntered)
                {
                    StartCoroutine(secondCubeTouch());
                }
            }
        }
    }

    IEnumerator firstCubeTouch()
    {
        firstCollider.enabled = false;
        secondCollider.enabled = false;
        meshRenderer.enabled = false;

        rightRayInteractor.SetActive(false);
        checkIfCubeIsEntered = true;

        firstPage.SetActive(false);
        secondPage.SetActive(true);

        yield return new WaitForSeconds(3);

        firstCollider.enabled = true;
        secondCollider.enabled = true;
        meshRenderer.enabled = true;
    }

    IEnumerator secondCubeTouch()
    {
        firstCollider.enabled = false;
        secondCollider.enabled = false;
        meshRenderer.enabled = false;

        rightRayInteractor.SetActive(true);
        checkIfCubeIsEntered = false;

        thisPage.SetActive(false);
        firstPage.SetActive(true);
        practiceModules.SetActive(false);
        practiceList.SetActive(true);

        yield return new WaitForSeconds(3);

        firstCollider.enabled = true;
        secondCollider.enabled = true;
        meshRenderer.enabled = true;
    }
}
