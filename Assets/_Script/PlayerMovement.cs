using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 8f;
    //[SerializeField] private float _speedDefault = 1f;
    //[SerializeField] private float _speedLevelUp = 0.2f;

    private void Update()
    {
        this.MoveUp();
    }

    private void MoveUp()
    {
        if (!InputManager.Instance.IsJump) return;
        PlayerCtrl.Instance.Rigidbody2D.velocity = Vector2.up * this._jumpForce;
    }

}
