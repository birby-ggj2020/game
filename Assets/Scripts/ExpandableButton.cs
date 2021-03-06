﻿using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ExpandableButton : MonoBehaviour
{
    public int NumParts = 5;
    public GameObject ButtonPrefab;
    public Transform MenuPanel;

    public void OnToggle(bool state){
        // var colors =this.GetComponent<Button>().colors;
        // colors.normalColor = state ? Color.green : Color.red ;
    }

    public void AddParts(IEnumerable<CreaturePart> parts,
                         Image head_img,
                         Image legs_img,
                         Image back_img,
                         Image tail_img/*,
                         Image skin_img*/) //TODO: how do we do skin??
    {
        foreach(var part in parts){
            var button = GameObject.Instantiate(ButtonPrefab);
            button.transform.SetParent(MenuPanel);
            var text = button.GetComponentInChildren<Text>();
            text.text = part.name;
            var b = button.GetComponent<Button>();
            b.onClick.AddListener(
                () => {
                    Debug.Log("Clicked Part '" + part.name + "'");
                    Image sprite = null;
                    switch(part.type){
                        case CreaturePartType.HEAD:
                            sprite = head_img;
                            GameState.active_habitat_state.creature.head = part;
                            break;
                        case CreaturePartType.LEGS:
                            sprite = legs_img;
                            GameState.active_habitat_state.creature.legs = part;
                            break;
                        case CreaturePartType.BACK:
                            sprite = back_img;
                            GameState.active_habitat_state.creature.back = part;
                            break;
                        case CreaturePartType.TAIL:
                            sprite = tail_img;
                            GameState.active_habitat_state.creature.tail = part;
                            break;
                        //TODO: how do we do skin??
                        // case CreaturePartType.SKIN:
                        //     sprite = skin_img;
                        //     break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    sprite.gameObject.SetActive(true);
                    sprite.sprite = part.sprite; 
                    
                }
            );
        }
    }
}
