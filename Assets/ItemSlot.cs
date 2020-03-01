using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using HutongGames.PlayMaker;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject Item;
    public GameObject GameManager;
    PlayMakerFSM MainFSM;
    CanvasGroup canvasGroup;
    
        

    public void Start()
    {
        MainFSM = GameManager.GetComponent<PlayMakerFSM>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Item = eventData.pointerDrag.gameObject;

            if (Item.tag == "Meat")
            {
                MainFSM.SendEvent("EatMeat");
                Destroy();
            }

            if (Item.tag == "Vege")
            {
                MainFSM.SendEvent("EatVege");
                Destroy();
                
            }

            if (Item.tag == "Milk")
            {
                MainFSM.SendEvent("EatMilk");
                Destroy();
            }

            if (Item.tag == "Ball")
            {
                MainFSM.SendEvent("EatBall");
                Destroy();

            }

            if (Item.tag == "Book")
            {
                MainFSM.SendEvent("EatBook");
                Destroy();
            }

            if (Item.tag == "Game")
            {
                MainFSM.SendEvent("EatGame");
                Destroy();

            }

            if (Item.tag == "Dust")
            {
                MainFSM.SendEvent("EatDust");
                Destroy();

            }

        }
    }

    public void Destroy()
    {
        Item.tag = "Untagged";
        Item.SetActive(false);
        canvasGroup = Item.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

    }
}
