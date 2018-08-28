using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelection : MonoBehaviour {

    // Use this for initialization
    public static ObjectSelection instance;
    public Sprite[] objects;
    public int currentSelectedObject = 0;
    public GameObject prefab;
    public Transform content;
	void Start () {
        instance = this;
        CreateObjects();
        UpdateObjects();

    }
	

    void CreateObjects()
    {
        for(int i=0;i< objects.Length;i++)
        {
            GameObject obj = Instantiate(prefab, content) as GameObject;
            obj.transform.Find("Image").gameObject.GetComponent<Image>().sprite = objects[i];
            int value = i;
            obj.GetComponent<Button>().onClick.AddListener(() => SelectObjects(value));
        }
    }
	
    void UpdateObjects()
    {
        foreach(Transform child in content)
        {
            child.transform.Find("Selected").gameObject.SetActive(false);
        }
        content.GetChild(currentSelectedObject).transform.Find("Selected").gameObject.SetActive(true);
    }

    void SelectObjects(int index)
    {
        currentSelectedObject = index;
        UpdateObjects();
    }
}
