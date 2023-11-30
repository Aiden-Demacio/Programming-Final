using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraMove(0.5f);
    }

    public void CameraMove(float i)
    {
        //transform.Translate(0.25f, 0.25f , 0.25f);
    }
}
