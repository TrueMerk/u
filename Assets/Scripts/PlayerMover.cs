using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private int _realSpeed = 3 ;
    public float speed;
    [SerializeField] private Rigidbody _rb;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, (float) 0.02 * _realSpeed);
            speed = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, (float) 0.02 * -_realSpeed);
            speed = 1;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
          
           _rb.transform.Rotate(0,-2,0);
        }
       
        else if (Input.GetKey(KeyCode.D))
        {
            _rb.transform.Rotate(0,2,0);
        }
        else
        {
            speed = 0;
        }
    }
}
