using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController CharContr;
    [SerializeField] private float speed;
    [SerializeField] private float walking;
    [SerializeField] private float running;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharContr = GetComponent<CharacterController>();
        CharContr.enabled = true;
        speed = walking;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector3 forward = transform.forward * verti;
        Vector3 right = transform.right * horiz;

        CharContr.SimpleMove(Vector3.Normalize(forward + right) * speed);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = running;
        }
    }
}
