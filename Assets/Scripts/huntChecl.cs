using UnityEngine;

public class huntChecl : MonoBehaviour
{
    public bool seeGreen;
    public bool seePrey;

    private void OnCollisionStay (Collision collision)
    {
        Debug.Log("hi");
        if(collision.gameObject.CompareTag("Grass"))
        {
            Debug.Log("grass!");
            seeGreen = true;
        }
        else { seeGreen = false; }

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("prey");
            seePrey = true;
        } else {  seePrey = false; }
    }
void onTriggerEnter (Collider other)
    {
        Debug.Log("hi");
    }
}

