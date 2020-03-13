using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFindSprite : MonoBehaviour
{
    //public new string name;
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        sprite = Resources.Load<Sprite>("긴 고양이");
        this.GetComponent<Image>().sprite = sprite;
    }
}
