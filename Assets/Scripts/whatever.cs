using UnityEngine;

public class whatever : MonoBehaviour
{
    public bool seeGreen;
    public bool seePrey;
    //private BoxCollider collider;
    private Rigidbody rb;
    void Start()
    {
        //collider = GetComponent<BoxCollider>();
        //rb = GetComponent<Rigidbody>();
        Debug.Log("hi");
    }
    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Grass"))
        {
            Debug.Log("grass!");
            seeGreen = true;
        }
        else { seeGreen = false; }

        if (seeGreen == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("prey");
                seePrey = true;
            }
            else { seePrey = false; }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
