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
        if(GameState.active_habitat_state.creature != null){
            Debug.Log("We have active habitat");
            if(GameState.active_habitat_state.creature.back != null){
                back_img.sprite = GameState.active_habitat_state.creature.back.sprite;
                back_img.gameObject.SetActive(true);
            }
            if(GameState.active_habitat_state.creature.head != null){
                head_img.sprite = GameState.active_habitat_state.creature.head.sprite;
                head_img.gameObject.SetActive(true);
            }
            if(GameState.active_habitat_state.creature.legs != null){
                legs_img.sprite = GameState.active_habitat_state.creature.legs.sprite;
                legs_img.gameObject.SetActive(true);
            }
            if(GameState.active_habitat_state.creature.tail != null){
                tail_img.sprite = GameState.active_habitat_state.creature.tail.sprite;
                tail_img.gameObject.SetActive(true);
            }
        }

        var buttons = new List<Button>(); 
        this.m_parts = CREATURE_PARTS.ALL;
        var groupedParts = this.m_parts.GroupBy(p => p.type);
        var toggleGroup = this.GetComponent<ToggleGroup>();

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
            var toggle = expandableButton.GetComponent<Toggle>();
            toggle.group = toggleGroup;
            
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