using UnityEngine;

public class AvatarController : MonoBehaviour
{
    [SerializeField] float speed;

    InputController inputController;
    Vector3 currentMovement;

    private void Update()
    {
        transform.position += currentMovement * speed * Time.deltaTime;
    }

    public void OnMoveInput(Vector2 moveInput)
    {
        currentMovement.x = moveInput.x;
        currentMovement.y = 0;
        currentMovement.z = moveInput.y;
    }
}