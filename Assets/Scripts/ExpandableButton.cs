using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ExpandableButton : MonoBehaviour
{
    public int NumParts = 5;
    public GameObject ButtonPrefab;
    public Transform MenuPanel;

    //public Sprite BodyImage;

    public void AddParts(IEnumerable<CreaturePart> parts, Image LimbsImage, Image SkinImage, Image HeadImage, Image AccessoryImage ){
        foreach(var part in parts){
            var button = GameObject.Instantiate(ButtonPrefab);
            button.transform.parent = MenuPanel;
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
                    //var image = sprite.GetComponent<Image>();
                    if(sprite != null){
                        Debug.Log("Sprite is not null");
                    } else {
                        Debug.Log("Sprite is null");

                    }

                    Debug.Log("part.name is " + part.name); 
                    if(part.sprite != null){
                        
                        Debug.Log("part.Sprite is not null");
                    } else {
                        Debug.Log("part.Sprite is null");

                    }
                    sprite.gameObject.SetActive(true);
                    sprite.sprite = part.sprite; 
                }
            );
        }
    }
}
