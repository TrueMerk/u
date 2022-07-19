using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform targetBone;
    public Vector3 rot;
    [SerializeField] private Camera _camera;

    private void Start()
    {
        rot = targetBone.localEulerAngles;
    }

    public void LateUpdate()
    {
        targetBone.localEulerAngles = rot;
    }

    private void Update()
    { 
         var mousePosition = Input.mousePosition;
         rot.x = mousePosition.x / 2;
         
    }
}
