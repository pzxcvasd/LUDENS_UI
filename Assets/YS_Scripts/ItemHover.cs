using UnityEngine;
using UnityEngine.EventSystems;

public class ItemHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject scriptImage;
    private GameObject ItemUseBtn;

    void Start() {
        ItemUseBtn = GameObject.FindGameObjectWithTag("useItem");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        scriptImage.SetActive(true);
        ItemUseBtn.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        scriptImage.SetActive(false);
        ItemUseBtn.SetActive(false);
    }
}
