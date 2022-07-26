using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform targetBone;
    public Vector3 rot;
    [SerializeField] private Camera _camera;
    private Vector3 _startTarget;

    private void Start()
    {
        rot = targetBone.localEulerAngles;
        _startTarget = rot;
        _startTarget.x = 0;
        _startTarget.y = 10;
        _startTarget.z = 10;
    }

    public void LateUpdate()
    {
        //targetBone.LookAt(rot,_startTarget);
       // targetBone.transform.Rotate(rot);
        
    }

    private void Update()
    { 
         // var mousePosition = Input.mousePosition;
         // var screenToCameraDistance = _camera.nearClipPlane;
         // var mousePosNearClipPlane = new Vector3(mousePosition.x, mousePosition.y, 40);
         // var worldPointPos = _camera.ScreenToWorldPoint(mousePosNearClipPlane);
         // Debug.Log(worldPointPos);
         // rot = worldPointPos;
        
        // rot.y = _startTarget.y;
        // rot.z = _startTarget.z;
         // targetBone.transform.Rotate(0, 0, 0f);

         //rot.x = mousePosNearClipPlane.x/2 ;

         Vector3 mousePosMain = Input.mousePosition;
         mousePosMain.z = _camera.transform.position.y;
         Vector3 curPosition = Camera.main.ScreenToWorldPoint(mousePosMain);
         Vector3 lookPos = curPosition - transform.position;
         
         lookPos.y = 0;
         Debug.Log(lookPos);
         transform.rotation = Quaternion.LookRotation(lookPos);
         
    }
}
