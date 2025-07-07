using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    private Animator animatorController;
    [SerializeField] private float velocity;
    [SerializeField] private float aceleration = 0.1f;
    [SerializeField] private float deseleretion = 0.5f;

    private void Awake()
    {
        animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        bool _move = Input.GetKey(KeyCode.W);
        bool _Footins = Input.GetKey(KeyCode.J);

        if (_move && velocity < 1)
        {
            velocity += Time.deltaTime * aceleration;
            animatorController.SetFloat("Velocity", velocity);
        }
        if (!_move && velocity > 0)
        {
            velocity -= Time.deltaTime * deseleretion;
            animatorController.SetFloat("Velocity", velocity);
        }

        if (_Footins)
        {
            animatorController.SetBool("Comer", true);
        }
        if (!_Footins)
        {
            animatorController.SetBool("Comer", false);
        }
    }
}
