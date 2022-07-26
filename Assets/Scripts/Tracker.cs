using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Vector3 rot;
    private void Update()
    {
       
    }
    public void LateUpdate()
    {
        Vector3 mousePosMain = Input.mousePosition;
        mousePosMain.z = _camera.transform.position.y;
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(mousePosMain);
        Vector3 lookPos = curPosition - transform.position;
        lookPos.y = 0;
        Debug.Log(lookPos);
        //transform.rotation = Quaternion.LookRotation(lookPos);
        //transform.localEulerAngles = lookPos;
      
    }
}
