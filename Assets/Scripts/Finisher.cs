using System;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    [SerializeField] private GameObject _sword;
    [SerializeField] private GameObject _gun;
    public Action FinisherEvent;
    public bool isFinishing = false;
    private float _curr;

    private void Start()
    {
        _sword.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FinisherEvent?.Invoke();
            isFinishing = true;
            _sword.gameObject.SetActive(true);
            _gun.gameObject.SetActive(false);
            _curr = 0.5f + Time.time;
            this.transform.position = other.gameObject.transform.position + Vector3.back;
            Vector3 s = new Vector3(this.transform.position.x, 0, this.transform.position.z);
            this.transform.position = s;
        }
       
    }

    private void Update()
    {
        if (isFinishing)
        {
            if (_curr<=Time.time)
            {
                isFinishing = false;
                _sword.gameObject.SetActive(false);
                _gun.gameObject.SetActive(true);
            }
        }
    }
}
