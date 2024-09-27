using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : LoboMonoBehaviour
{

    [SerializeField] private List<Transform> avatars = new List<Transform>();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAvatars();
    }

    private void LoadAvatars()
    {
        if (avatars.Count > 0) return;
        
        foreach (Transform transform in transform)
        {
            this.avatars.Add(transform);
        }

        Debug.LogWarning(transform.name + ": LoadAvatars", gameObject);
    }

}
