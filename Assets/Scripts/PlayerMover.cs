using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMover : MonoBehaviour
{
    private int _realSpeed = 3 ;
    public float speed;
    [SerializeField] private Transform _leftLeg;
    [SerializeField] private Transform _rightLeg;
    [SerializeField] private Transform _chest;
    [SerializeField] private Transform _cube;
    [SerializeField] private Transform _legs;
    public Quaternion rot;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _legs.transform.Translate(0, 0, (float) 0.02 * -_realSpeed);
            speed = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _legs.transform.Translate(0, 0, (float) 0.02 * _realSpeed);
            speed = 1;
        }
        else
        {
            speed = 0;
        }

        var pos = _legs.transform.position;
        pos.y = 0;
        transform.position = pos;
       
       
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _legs.transform.Rotate(0,-2,0);
            _cube.transform.rotation = transform.rotation;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _cube.transform.rotation = transform.rotation;
            _legs.transform.Rotate(0,2,0);
        }
        else
        {
           
            speed = 0;
        }
         
         var legsTarget = _legs.transform.localEulerAngles;
         var leftLegTarget = legsTarget;
         var rightLegTarget = legsTarget;
         rightLegTarget.x = -legsTarget.y;
         rightLegTarget.y = rot.y;
         rightLegTarget.z = 150;
         leftLegTarget.x = -legsTarget.y;
         leftLegTarget.y = 0;
         leftLegTarget.z = 5;
         _rightLeg.localEulerAngles = rightLegTarget;
         _leftLeg.localEulerAngles = leftLegTarget;
       
    }

    private void Start()
    {
        rot = _rightLeg.transform.rotation;
    }
}
