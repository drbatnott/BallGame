using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActivation : MonoBehaviour
{
    bool hit = false;
    Transform targetsTransform;
    // Start is called before the first frame update
    void Start()
    {
        targetsTransform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(hit && targetsTransform.position.y < 10)
        {
            Vector3 v3 = targetsTransform.position;
            v3.y += Time.deltaTime;
            targetsTransform.position = v3;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        //this.gameObject.SetActive(false);
        hit = true;
        //Debug.Log(hit);
    }
}
