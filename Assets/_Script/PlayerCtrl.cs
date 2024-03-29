using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance => _instance;

    [SerializeField] private PlayerAvatar _avatar;
    public PlayerAvatar Avatar => _avatar;

    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAvatar();
    }

    private void LoadAvatar()
    {
        if (this._avatar != null) return;
        this._avatar = GetComponentInChildren<PlayerAvatar>();
        Debug.LogWarning(transform.name + ": LoadAvatar", gameObject);
    }

}
