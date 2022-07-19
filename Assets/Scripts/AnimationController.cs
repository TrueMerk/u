using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        _animator.SetFloat("speed",GetComponent<PlayerMover>().speed);
        _animator.SetBool("isFinishing",GetComponent<Finisher>().isFinishing);
        
    }
}
