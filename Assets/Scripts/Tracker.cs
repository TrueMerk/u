using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = _camera.ScreenToWorldPoint(mousePosition);
        var screenToCameraDistance = _camera.nearClipPlane;
        var mousePosNearClipPlane = new Vector3(mousePosition.x, mousePosition.y, screenToCameraDistance);
        var worldPointPos = _camera.ScreenToWorldPoint(mousePosNearClipPlane);
     
        
       
    }
}
