using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ExpandableButton : MonoBehaviour
{
    public int NumParts = 5;
    public GameObject ButtonPrefab;
    public Transform MenuPanel;

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
            Debug.Log("Adding button click");
            var b = button.GetComponent<Button>();
            if(b != null){
                Debug.Log("Found button");
            }
            b.onClick.AddListener(
                () => {
                    Debug.Log("Clicked");
                    Image sprite = null;
                    switch(part.type){
                        case CreaturePartType.HEAD:
                            sprite = head_img;
                            break;
                        case CreaturePartType.LEGS:
                            sprite = legs_img;
                            break;
                        case CreaturePartType.BACK:
                            sprite = back_img;
                            break;
                        case CreaturePartType.TAIL:
                            sprite = tail_img;
                            break;
                        //TODO: how do we do skin??
                        // case CreaturePartType.SKIN:
                        //     sprite = skin_img;
                        //     break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    Debug.Log("Clicked");
                    sprite.gameObject.SetActive(true);
                    sprite.sprite = part.sprite; 
                }
            );
        }
    }
}
