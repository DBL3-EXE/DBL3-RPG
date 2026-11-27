using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 MoveInput;
    private Vector2 MouseInput;

    public float moveSpeed;

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }

    public void onMouse(InputAction.CallbackContext context)
    {
        MouseInput = context.ReadValue<Vector2>();
    }
    
    private void Update()
    {
        transform.Translate(MoveInput * Time.deltaTime * moveSpeed);
    }

}
