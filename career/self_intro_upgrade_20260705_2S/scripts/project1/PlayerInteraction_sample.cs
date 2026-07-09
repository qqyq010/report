// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using UnityEngine;

public interface IProject1InteractableSample
{
    float GetInteractDistance();
    void Interact();
}

public enum Project1InteractionRayMode
{
    CenterScreen,
    MousePosition
}

public sealed class Project1PlayerInteractionSample : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _interactionOrigin;
    [SerializeField] private LayerMask _interactLayer;
    [SerializeField] private float _defaultInteractDistance = 5f;
    [SerializeField] private float _rayDistance = 100f;
    [SerializeField] private Project1InteractionRayMode _rayMode = Project1InteractionRayMode.CenterScreen;

    private bool _interactionEnabled = true;

    private void Awake()
    {
        if (_interactionOrigin == null)
            _interactionOrigin = transform;
    }

    private void Update()
    {
        if (!_interactionEnabled || _camera == null)
            return;

        if (Input.GetMouseButtonDown(0))
            TryInteract();
    }

    public void SetInteractionEnabled(bool enabled)
    {
        _interactionEnabled = enabled;
    }

    public void SetRayMode(Project1InteractionRayMode rayMode)
    {
        _rayMode = rayMode;
    }

    private void TryInteract()
    {
        if (!TryGetInteractableHit(out RaycastHit hit, out IProject1InteractableSample interactable))
            return;

        if (!IsWithinInteractDistance(interactable, hit.point))
            return;

        interactable.Interact();
    }

    private bool TryGetInteractableHit(out RaycastHit hit, out IProject1InteractableSample interactable)
    {
        hit = default;
        interactable = null;

        Vector3 screenPoint = _rayMode == Project1InteractionRayMode.MousePosition
            ? Input.mousePosition
            : new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0f);

        Ray ray = _camera.ScreenPointToRay(screenPoint);
        if (!Physics.Raycast(ray, out hit, _rayDistance, _interactLayer))
            return false;

        if (hit.collider.TryGetComponent(out interactable))
            return true;

        interactable = hit.collider.GetComponentInParent<IProject1InteractableSample>();
        return interactable != null;
    }

    private bool IsWithinInteractDistance(IProject1InteractableSample interactable, Vector3 hitPoint)
    {
        float interactDistance = interactable.GetInteractDistance();
        if (interactDistance <= 0f)
            interactDistance = _defaultInteractDistance;

        return Vector3.Distance(_interactionOrigin.position, hitPoint) <= interactDistance;
    }
}
