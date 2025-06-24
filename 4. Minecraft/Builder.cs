using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField] private float _checkDistance;
    [SerializeField] private Transform _raycastPoint;
    [SerializeField] private Block _blockPrefabe;
    [SerializeField] private BuildPreview _buildPreview;

    private RaycastHit _hitinfo;

    private Vector3 BuildPosition => _hitinfo.transform.position + _hitinfo.normal;

    private void Update()
    {
        if (_hitinfo.transform == null) 
            return;

        if (_hitinfo.transform.GetComponent<Block>() == null) 
            return;

        if (Input.GetMouseButtonDown(0)) 
            Build();
    }

    //»сп. превью и raycast
    private void FixedUpdate()
    {
        if(Physics.Raycast(_raycastPoint.position, _raycastPoint.forward, out _hitinfo, _checkDistance))
        {
            if(_buildPreview.IsActive == false)
            {
                _buildPreview.Enable();
            }

            _buildPreview.SetPosition(BuildPosition);
        }
    }

    private void Build()
    {
        Vector3 position = BuildPosition;

        Instantiate(_blockPrefabe, position, Quaternion.identity);
    }
}
