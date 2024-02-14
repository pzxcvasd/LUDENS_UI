using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSubMenu : MonoBehaviour
{
    public GameObject set;
    public GameObject item;
    bool clickedItem,clickedSettings = true;
    public void OnClikItemMenu() {
        set.SetActive(false);
        if(clickedItem) {
            item.SetActive(true);
            clickedItem = false;
        }
        else {
            item.SetActive(false);
            clickedItem = true;
        }
    }

    public void OnClickSettingMenu() {
        item.SetActive(false);
        if(clickedSettings) {
            set.SetActive(true);
            clickedSettings = false;
        }
        else {
            set.SetActive(false);
            clickedSettings = true;
        }
}
}
