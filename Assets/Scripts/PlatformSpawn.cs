using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformSpawn : MonoBehaviour
{
    [SerializeField] private Vector3 location;
    [SerializeField] GameObject spawn;
    [SerializeField] GameObject Collectable;
    private float move = 3f;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        spawn.GetComponent<Position>();
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0, 2);
        if(  rand < 1)
        {
            transform.Translate(move, 0, 0);
        }
        else
        {
            transform.Translate(0, 0, move);
        }
        Instantiate(spawn, transform.position, transform.rotation);
        Instantiate(Collectable, transform.position, transform.rotation);
        
    }

}
