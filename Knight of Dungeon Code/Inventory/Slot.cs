using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private Vector3 oriPos;
    private Button slotButton;
    public Item item;
    public int itemCount;
    public Image itemImage;
    [SerializeField]
    private Text text_Count;
    [SerializeField]
    private GameObject CountImage;
    private ItemEffect itemEffect;

    // Start is called before the first frame update
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }
    public void AddItem(Item _item, int _count = 1)//æ∆¿Ã≈€ »πµÊ
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.ItemImage;

        if (item.itemType != Item.ItemType.Equipment)
        {
            CountImage.SetActive(true);
            text_Count.text = itemCount.ToString();
        }
        else
        {
            text_Count.text = "0";
            CountImage.SetActive(false);
        }
        SetColor(1);
    }
   
}
