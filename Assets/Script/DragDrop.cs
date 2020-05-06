using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using HutongGames.PlayMaker;


public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDropHandler, IDragHandler {
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Start()
    {
      
            canvas = GameObject.Find("Canvas").GetComponent<Canvas>();                
      
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(GetComponent<RectTransform>().anchoredPosition);
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        /*
        if (GetComponent<RectTransform>().anchoredPosition.x > 470)
        {
            PlayMakerFSM.BroadcastEvent("DestroyItem");
            Destroy();
        }

        if (GetComponent<RectTransform>().anchoredPosition.y < -880)
        {
            PlayMakerFSM.BroadcastEvent("DestroyItem");
            Destroy();
        }
        */
        
    }
    

        public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        
    }

    public void Destroy()
    {
        if (this.tag == "Dust") {
            FsmVariables.GlobalVariables.GetFsmInt("Int_CurrentDust").Value--;
        }

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        this.tag = "Untagged";
        this.gameObject.SetActive(false);


        
    }
}
