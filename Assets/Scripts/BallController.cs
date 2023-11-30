using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed;
    public GameObject Ball;
    private bool fall = false;
    [SerializeField] private Rigidbody rb;
    Vector3 movDir;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.init(this);
        InputManager.gameMode();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        pos = Ball.transform.position;
        transform.Translate(speed * Time.deltaTime * movDir);
        //rb.AddForce(speed * Time.deltaTime * movDir, ForceMode.Impulse);
        //CameraScript.positionTracker(pos);
        //if (movDir.x == 1)
        //{
            
        //}
        if (fall)
        {
            transform.Translate(0, -1, 0);
        }
    }

    public void SetMovDir(Vector3 MovDir)
    {
        
        movDir = MovDir;
        print(movDir);
    }

    public void switchDir(bool dirSwitch)
    {
        if (dirSwitch)
        {
            movDir.x = 0;
            movDir.z = 1;
        }
        else
        {
            movDir.z = 0;
            movDir.x = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other == null)
        {
            fall = true;
        }
    }
}