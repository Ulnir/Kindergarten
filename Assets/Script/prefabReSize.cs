using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabReSize : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
        transform.SetParent(transform.parent.transform);
        Debug.Log(transform.parent.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTranformParent()
    {

        transform.SetParent(transform.parent.transform);
        Debug.Log(transform.parent.name);


    }
}
