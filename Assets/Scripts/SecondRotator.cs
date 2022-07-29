using UnityEngine;

public class SecondRotator : MonoBehaviour
{
    
    [SerializeField]private Camera _camera;
    [SerializeField] private Transform _chest;

    
    private void LateUpdate()
    {
        
        var mousePosMain = Input.mousePosition;
        mousePosMain.z = _camera.transform.position.y;
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(mousePosMain);
        Vector3 lookPos = curPosition - transform.position;
        var lookVector = new Vector3(lookPos.x, 0, lookPos.z);
        Transform transform1;
        (transform1 = transform).rotation = Quaternion.LookRotation(lookVector);
        transform1.position = _chest.position;
        

    }
}
