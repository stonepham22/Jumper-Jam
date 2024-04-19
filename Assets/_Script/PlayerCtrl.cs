using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance => _instance;

    [SerializeField] private PlayerAvatar _avatar;
    public PlayerAvatar Avatar => _avatar;

    [SerializeField] private Rigidbody2D _rigidbody2D;
    public Rigidbody2D Rigidbody2D => _rigidbody2D;

    private void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }

    private void Reset()
    {
        this.LoadAvatar();
        this.LoadRigibody2D();
    }

    private void LoadAvatar()
    {
        if (this._avatar != null) return;
        this._avatar = GetComponentInChildren<PlayerAvatar>();
        Debug.LogWarning(transform.name + ": LoadAvatar", gameObject);
    }

    private void LoadRigibody2D()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponentInChildren<Rigidbody2D>();
        Debug.LogWarning(transform.name + ": LoadPlayerRigibody2D", gameObject);
    }

}
