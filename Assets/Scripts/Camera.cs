using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CameraScript : MonoBehaviour
{

    [SerializeField] private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //camera.transform.position = BallController.Ball.position; 
    }

    public void positionTracker(Vector3 pos)
    {
        camera.transform.position = pos;
    }

    public void CameraMove(int i)
    {
        transform.Translate(i * camera.transform.forward);
    }
}
