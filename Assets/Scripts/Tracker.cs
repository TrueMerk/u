using UnityEngine;

public class Tracker : MonoBehaviour
{
    private Vector3 rot;
    [SerializeField] private GameObject _cube;
    
    public void LateUpdate()
    {
        var rotateTo = _cube.transform.localEulerAngles;
        var rotateTo2 = rotateTo;
        rotateTo2.x = -rotateTo.y;
        rotateTo2.y = 0;
        transform.localEulerAngles = rotateTo2;
    }
}
