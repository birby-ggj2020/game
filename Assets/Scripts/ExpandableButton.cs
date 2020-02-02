using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ExpandableButton : MonoBehaviour
{
    public int NumParts = 5;
    public GameObject ButtonPrefab;
    public Transform MenuPanel;

    public void AddParts(IEnumerable<CreaturePart> parts, Image LimbsImage, Image SkinImage, Image HeadImage, Image AccessoryImage ){

        foreach(var part in parts){
            var button = GameObject.Instantiate(ButtonPrefab);
            button.transform.SetParent(MenuPanel);
            var text = button.GetComponentInChildren<Text>();
            text.text = part.name;

            button.GetComponent<Button>().onClick.AddListener(
                () => {
                    Image sprite = null;
                    switch(part.type){
                        case CreaturePartType.ACCESSORY:
                            sprite = AccessoryImage;
                            break;
                        case CreaturePartType.HEAD:
                            sprite = HeadImage;
                            break;
                        case CreaturePartType.LIMBS:
                            sprite = LimbsImage;
                            break;
                        case CreaturePartType.SKIN:
                            sprite = SkinImage;
                            break;
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
