using UnityEngine;
using UnityEngine.EventSystems;

public class ItemHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject scriptImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        scriptImage.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        scriptImage.SetActive(false);
    }
}
