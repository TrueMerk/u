using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Transform _transform;
    private Vector3 _temp;
    private void Start()
    {
        _temp.y = transform.position.y+5;
    }
    private void Update()
    {
        var position = _player.transform.position;
        _temp.x = position.x+10;
        _temp.z = position.z+10;
        transform.position = _temp;
    }
}
