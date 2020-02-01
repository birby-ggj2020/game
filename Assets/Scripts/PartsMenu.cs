using System;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Collections.Generic;

public class PartsMenu : MonoBehaviour
{
    private List<CreaturePart> m_parts;

    public GameObject PartButtonPrefab;

    public Image LimbsImage;
    public Image SkinImage;
    public Image HeadImage;
    public Image AccessoryImage;
    void Start()
    {
        this.m_parts = GameState.creature_parts;
        var groupedParts = this.m_parts.GroupBy(p => p.type);

        foreach(var grouping in groupedParts){
            var partButton = Instantiate(PartButtonPrefab, new Vector3(0,0,0), Quaternion.identity);
            var text = partButton.GetComponentInChildren<Text>();
            text.text = TypeToString(grouping.Key);
            partButton.transform.parent = this.transform;
            var expandableButton = partButton.GetComponentInChildren<ExpandableButton>();
            expandableButton.AddParts(grouping, LimbsImage, SkinImage, HeadImage, AccessoryImage);        
        }
    }
    private string TypeToString(CreaturePartType type){
        switch(type){
            case CreaturePartType.ACCESSORY:
                return "Accessories";
            case CreaturePartType.HEAD:
                return "Heads";
            case CreaturePartType.LIMBS:
                return "Limbs";
            case CreaturePartType.SKIN:
                return "Skins";
            default:
                throw new ArgumentOutOfRangeException("");
        }
    }
    

    //  public static T[] GetAllInstances<T>() where T : ScriptableObject
    //  {
    //      string[] guids = AssetDatabase.FindAssets("t:"+ typeof(T).Name);  //FindAssets uses tags check documentation for more info
    //      T[] a = new T[guids.Length];
    //      for(int i =0;i<guids.Length;i++)         //probably could get optimized 
    //      {
    //          string path = AssetDatabase.GUIDToAssetPath(guids[i]);
    //          a[i] = AssetDatabase.LoadAssetAtPath<T>(path);
    //      }      
    //      return a;
    //  }
     

    // Update is called once per frame
    void Update()
    {
        
    }
}