using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using HutongGames.PlayMaker;

public class TrashSlot : MonoBehaviour, IDropHandler
{
    public GameObject Item;
    //public GameObject GameManager;
    PlayMakerFSM MainFSM;
    CanvasGroup canvasGroup;



    public void Start()
    {
        //MainFSM = GameManager.GetComponent<PlayMakerFSM>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Item = eventData.pointerDrag.gameObject;

            PlayMakerFSM.BroadcastEvent("DestroyItem");
            Destroy();

        }
    }

    public void Destroy()
    {

        PlayMakerFSM.BroadcastEvent("DestroyItem");


        if (Item.tag == "Dust")
        {
            FsmVariables.GlobalVariables.GetFsmInt("Int_CurrentDust").Value--;
            
        }

        Item.tag = "Untagged";
        Item.SetActive(false);
        canvasGroup = Item.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;



    }
}
