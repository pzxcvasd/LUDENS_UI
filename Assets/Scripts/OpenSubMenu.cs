using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSubMenu : MonoBehaviour
{
    public GameObject set;
    public GameObject item;
    public void OnClikItemMenu() {
        Debug.Log("Cliked Item Menu");
        set.SetActive(false);
        item.SetActive(true);

    }

    public void OnClickSettingMenu() {
        Debug.Log("Cliked Setting Menu");
        set.SetActive(true);
        item.SetActive(false);

    }
}
