using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFindSprite : MonoBehaviour
{
    public new string name;
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load(name) as Sprite;
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
