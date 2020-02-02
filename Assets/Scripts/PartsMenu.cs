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

    public Image head_img;
    public Image legs_img;
    public Image back_img;
    public Image tail_img;
    // public Image skin_img; //TODO: how do we do skin??

    void Start()
    {
        this.m_parts = GameState.creature_parts;
        var groupedParts = this.m_parts.GroupBy(p => p.type);

        foreach(var grouping in groupedParts){
            var partButton = Instantiate(PartButtonPrefab, new Vector3(0,0,0), Quaternion.identity);
            var text = partButton.GetComponentInChildren<Text>();
            text.text = TypeToString(grouping.Key);
            partButton.transform.SetParent(this.transform);
            var expandableButton = partButton.GetComponentInChildren<ExpandableButton>();
            expandableButton.AddParts(
                grouping,
                this.head_img,
                this.legs_img,
                this.back_img,
                this.tail_img/*,
                this.skin_img*/ //TODO: how do we do skin??
            );
        }
    }
    private string TypeToString(CreaturePartType type){
        switch(type){
            case CreaturePartType.HEAD:
                return "Head";
            case CreaturePartType.LEGS:
                return "Legs";
            case CreaturePartType.BACK:
                return "Back";
            case CreaturePartType.TAIL:
                return "Tail";
            case CreaturePartType.SKIN:
                return "Skin";
            default:
                throw new ArgumentOutOfRangeException("");
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
}