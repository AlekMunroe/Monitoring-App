using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomMenuController : MonoBehaviour
{
    [SerializeField] private GameObject[] screens;

    public void OpenScreen(GameObject screenName)
    {
        if (!screenName.activeInHierarchy)
        {
            CloseAllScreens();

            screenName.SetActive(true);
        }
    }
    
    void CloseAllScreens()
    {
        foreach (GameObject screen in screens)
        {
            screen.SetActive(false);
        }
    }
}
