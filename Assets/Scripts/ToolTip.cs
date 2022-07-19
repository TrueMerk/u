using UnityEngine;


public class ToolTip : MonoBehaviour
{
    [SerializeField] private GameObject _text;
    private void OnTriggerEnter(Collider other)
    {
        _text.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _text.SetActive(false);
    }
}
