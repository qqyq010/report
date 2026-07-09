// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public sealed class Project1PlayerMoveSample : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _cameraPivot;
    [SerializeField] private float _moveSpeed = 3.5f;
    [SerializeField] private float _inputDeadZone = 0.01f;

    private Vector2 _moveInput;
    private bool _movementEnabled = true;

    public bool IsMoving { get; private set; }

    private void Awake()
    {
        if (_rigidbody == null)
            _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!_movementEnabled)
        {
            _moveInput = Vector2.zero;
            IsMoving = false;
            return;
        }

        Vector2 input = new Vector2(
            Input.GetAxisRaw(HorizontalAxis),
            Input.GetAxisRaw(VerticalAxis)
        );

        if (input.sqrMagnitude > 1f)
            input.Normalize();

        _moveInput = input.sqrMagnitude <= _inputDeadZone * _inputDeadZone
            ? Vector2.zero
            : input;
    }

    private void FixedUpdate()
    {
        if (_rigidbody == null)
            return;

        Vector3 moveDirection = ResolveMoveDirection(_moveInput);
        Vector3 velocity = _rigidbody.velocity;
        velocity.x = moveDirection.x * _moveSpeed;
        velocity.z = moveDirection.z * _moveSpeed;
        _rigidbody.velocity = velocity;

        IsMoving = new Vector2(velocity.x, velocity.z).sqrMagnitude > 0.0001f;
    }

    public void SetMovementEnabled(bool enabled)
    {
        _movementEnabled = enabled;
    }

    private Vector3 ResolveMoveDirection(Vector2 input)
    {
        if (input.sqrMagnitude <= 0.0001f)
            return Vector3.zero;

        Vector3 forward = _cameraPivot != null ? _cameraPivot.forward : transform.forward;
        Vector3 right = _cameraPivot != null ? _cameraPivot.right : transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 direction = forward * input.y + right * input.x;
        return direction.sqrMagnitude > 1f ? direction.normalized : direction;
    }
}
