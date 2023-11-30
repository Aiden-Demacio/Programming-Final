using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platform;
    
    // Start is called before the first frame update
    void Start()
    {
        platform.transform.Translate(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            platform.transform.Translate(0, -1, 0);
        }
    }
}
