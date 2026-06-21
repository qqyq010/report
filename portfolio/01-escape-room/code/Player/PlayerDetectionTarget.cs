using UnityEngine;

// 적 시야가 플레이어 루트 대신 가슴/머리 같은 더 안정적인 지점을 볼 수 있게 해주는 마커.
public class PlayerDetectionTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private bool _drawGizmo = true;
    [SerializeField] private Color _gizmoColor = Color.cyan;
    [SerializeField] private float _gizmoRadius = 0.12f;

    public Transform Target => _target != null ? _target : transform;

    private void Reset()
    {
        if (_target == null)
            _target = transform;
    }

    public static Transform ResolveTransform(Transform playerRoot)
    {
        if (playerRoot == null)
            return null;

        PlayerDetectionTarget marker = playerRoot.GetComponentInChildren<PlayerDetectionTarget>(true);
        if (marker != null && marker.Target != null)
            return marker.Target;

        return playerRoot;
    }

    private void OnDrawGizmosSelected()
    {
        if (!_drawGizmo)
            return;

        Transform target = Target;
        if (target == null)
            return;

        Gizmos.color = _gizmoColor;
        Gizmos.DrawWireSphere(target.position, Mathf.Max(0.01f, _gizmoRadius));
    }
}
