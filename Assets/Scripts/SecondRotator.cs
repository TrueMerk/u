using UnityEngine;

public class SecondRotator : MonoBehaviour
{
    
    public float moveSpeed = 2f;
    [SerializeField]private Camera _camera;
    public Vector3 rot;

    private void LateUpdate()
    {
        
        Vector3 mousePosMain = Input.mousePosition;
        mousePosMain.z = _camera.transform.position.y;
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(mousePosMain);
        Vector3 lookPos = curPosition - transform.position;
       var LookVector = new Vector3(lookPos.x, 0, lookPos.z);
       // var LookVector = new Vector3(0, 0, 0);
        Debug.Log(LookVector);
        transform.rotation = Quaternion.LookRotation(LookVector);
       // transform.localEulerAngles = LookVector + LookVector2;
       // transform.rotation = Quaternion.Euler(rot);
      // transform.localEulerAngles = lookPos;

    }
}
