using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Create Sculpture", order = 0)]
[System.Serializable]
public class Sculpture : ScriptableObject {

    public GameObject s_prefab;
    public Sprite s_icon;
    [TextArea]
    public string description;
}
