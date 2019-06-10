using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Transform character;

    private Animator animator;

    private void Start()
    {
        animator = character.GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Walk", false);
        }
    }
}
