using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficConeController : MonoBehaviour
{
    // カメラに写っていないときに呼ばれる関数
    void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
