// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using System;
using UnityEngine;

public sealed class Project1EnemyVisionSample : MonoBehaviour
{
    [SerializeField] private Transform _viewOrigin;
    [SerializeField] private Transform _targetRoot;
    [SerializeField] private Transform _targetViewPoint;
    [SerializeField] private float _detectionRange = 10f;
    [SerializeField, Range(1f, 180f)] private float _viewAngle = 60f;
    [SerializeField] private LayerMask _visibilityMask = ~0;
    [SerializeField] private float _redetectCooldown = 0.2f;

    private float _lastDetectionTime = -999f;

    public event Action<Project1EnemyVisionSample> PlayerDetected;

    private void Awake()
    {
        if (_viewOrigin == null)
            _viewOrigin = transform;
    }

    private void Update()
    {
        if (_targetRoot == null)
            return;

        Transform targetPoint = _targetViewPoint != null ? _targetViewPoint : _targetRoot;
        Vector3 origin = _viewOrigin.position;
        Vector3 toTarget = targetPoint.position - origin;
        float distance = toTarget.magnitude;

        if (!IsInRange(distance))
            return;

        Vector3 direction = toTarget / distance;
        if (!IsInsideViewAngle(direction))
            return;

        if (!HasLineOfSight(origin, direction, distance))
            return;

        if (Time.time < _lastDetectionTime + _redetectCooldown)
            return;

        _lastDetectionTime = Time.time;
        PlayerDetected?.Invoke(this);
    }

    private bool IsInRange(float distance)
    {
        return distance > 0.001f && distance <= _detectionRange;
    }

    private bool IsInsideViewAngle(Vector3 direction)
    {
        float angle = Vector3.Angle(_viewOrigin.forward, direction);
        return angle <= _viewAngle * 0.5f;
    }

    private bool HasLineOfSight(Vector3 origin, Vector3 direction, float distance)
    {
        if (!Physics.Raycast(origin, direction, out RaycastHit hit, distance, _visibilityMask, QueryTriggerInteraction.Ignore))
            return false;

        return hit.transform == _targetRoot || hit.transform.IsChildOf(_targetRoot);
    }
}
