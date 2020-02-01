using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

public class PartsMenu : MonoBehaviour
{
    private Part[] m_parts;

    public GameObject PartButtonPrefab;
    void Start()
    {
        this.m_parts = GetAllInstances<Part>();
        var groupedParts = this.m_parts.GroupBy(p => p.Type);

        foreach(var grouping in groupedParts){
            var partButton = Instantiate(PartButtonPrefab, new Vector3(0,0,0), Quaternion.identity);
            partButton.transform.parent = this.transform;
            var expandableButton = partButton.GetComponentInChildren<ExpandableButton>();
            expandableButton.AddParts(grouping);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollapseAll(){
        for(var i = 0; i < this.transform.childCount; i++){
            this.transform.GetChild(i);

        }
    }

     public static T[] GetAllInstances<T>() where T : ScriptableObject
     {
         string[] guids = AssetDatabase.FindAssets("t:"+ typeof(T).Name);  //FindAssets uses tags check documentation for more info
         T[] a = new T[guids.Length];
         for(int i =0;i<guids.Length;i++)         //probably could get optimized 
         {
             string path = AssetDatabase.GUIDToAssetPath(guids[i]);
             a[i] = AssetDatabase.LoadAssetAtPath<T>(path);
         }
 
         return a;

     }
}