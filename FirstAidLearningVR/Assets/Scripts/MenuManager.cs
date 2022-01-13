using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class MenuManager : MonoBehaviour
{
    public XRNode inputSource;
    public Panel currentPanel = null;
    public bool gripValue = false;

    private List<Panel> panelHistory = new List<Panel>();

    private void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        Panel[] panels = GetComponentsInChildren<Panel>();

        foreach (Panel panel in panels)
            panel.Setup(this);

        currentPanel.Show();
    }

    private void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        if (device.TryGetFeatureValue(CommonUsages.gripButton, out gripValue) && gripValue)
            GoToPrevious();
    }

    public void GoToPrevious()
    {
        if(panelHistory.Count == 0)
        {
            Application.Quit();
            return;
        }
        int lastIndex = panelHistory.Count - 1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }

    public void SetCurrentWithHistory(Panel newPanel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(newPanel);
    }

    private void SetCurrent(Panel newPanel)
    {
        currentPanel.Hide();

        currentPanel = newPanel;
        currentPanel.Show();
    }
}