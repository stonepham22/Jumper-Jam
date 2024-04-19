using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance => _instance;

    [SerializeField] private bool _isJump;
    public bool IsJump  => _isJump;

    private void Awake()
    {
        if (InputManager._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        InputManager._instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) this._isJump = true;
        if (Input.GetMouseButtonUp(0)) this._isJump = false;
    }

}
