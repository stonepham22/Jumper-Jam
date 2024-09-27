using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{

    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private Vector3 _targetPosition = new Vector3(1.5f, 0, 0);

    private void OnEnable()
    {
        this._targetPosition.y = transform.position.y;
    }
    private void FixedUpdate()
    {
        this.Move();
        this.CheckTargetPosition();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, this._targetPosition, this._speed * Time.fixedDeltaTime);
    }

    private void CheckTargetPosition()
    {
        if (transform.position.x == 1.5f) this._targetPosition.x = -1.5f;
        else if (transform.position.x == -1.5f) this._targetPosition.x = 1.5f;
    }    


}
