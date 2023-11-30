using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    [SerializeField] private Rigidbody rb;
    Vector3 movDir;
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
        rb.AddForce(speed * Time.deltaTime * movDir, ForceMode.Impulse);

    }

    public void SetMovDir(Vector3 MovDir)
    {
        movDir = MovDir;
        print(movDir);
    }
}