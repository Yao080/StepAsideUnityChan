using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // ƒJƒƒ‰‚ÉÊ‚Á‚Ä‚¢‚È‚¢‚Æ‚«‚ÉŒÄ‚Î‚ê‚éŠÖ”
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
