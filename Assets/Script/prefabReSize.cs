using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabReSize : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        

        this.transform.SetParent(parent.transform, false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
