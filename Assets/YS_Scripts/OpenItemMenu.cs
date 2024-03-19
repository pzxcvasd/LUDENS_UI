using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemMenu : MonoBehaviour
{
    public GameObject TurnMenu;
    public GameObject ItemMenu;

    void Start() {
        ItemMenu.SetActive(false);
    }
    public void OnClikItemMenu() {
        TurnMenu.SetActive(false);
        ItemMenu.SetActive(true);
    }

    public void CloseItemMenu() {
        ItemMenu.SetActive(false);
        TurnMenu.SetActive(true);
    }

}
