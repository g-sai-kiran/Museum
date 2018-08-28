using GoogleARCore.Examples.HelloAR;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SculptureManager : MonoBehaviour {

    [SerializeField] HelloARController controller;
    public List<Sculpture> sculptures = new List<Sculpture>();
    public Transform parent_list;
    public GameObject prefab;

    private void Awake()
    {
        sculptures = Resources.LoadAll<Sculpture>("Sculptures").ToList();
        GenerateSculptures();
    }

    public void GenerateSculptures()
    {
        foreach (Sculpture sculpture in sculptures)
        {
            Button s_button = (Instantiate(prefab, parent_list) as GameObject).GetComponent<Button>();
            s_button.gameObject.name = sculpture.name;
            (s_button.targetGraphic as Image).sprite = sculpture.s_icon;
            s_button.onClick.AddListener(delegate { SculptureClick(s_button.transform); });
        }
    }

    public void SculptureClick(Transform button)
    {
        if(button != null)
        {
            foreach (Transform item in button.parent)
            {
                item.GetChild(0).gameObject.SetActive(item == button);
            }
            controller.AndyPlanePrefab = sculptures[button.GetSiblingIndex()].s_prefab;
        }
    }

    
}
