﻿using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName ="ManagerEvents", menuName = "Managers/ManagersEvents")]

public class ManagerEvents : ManagerBase
{
    public GameObject prefab;

    public void CratePrefab(Vector3 pos)
    {
        Instantiate(prefab, pos, Quaternion.identity);
    }
}