using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class Diary : ScriptableObject
{
    [Header("info")]
    public string displayName;
    public string description;
}