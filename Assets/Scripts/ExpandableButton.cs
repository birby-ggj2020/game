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
                    switch(part.type.name){
                        case "accessory":
                            sprite = AccessoryImage;
                            break;
                        case "head":
                            sprite = HeadImage;
                            break;
                        case "limbs":
                            sprite = LimbsImage;
                            break;
                        case "skin":
                            sprite = SkinImage;
                            break;
                        default:
                            Debug.Log(part.type.name);
                            Debug.Log(part.name);
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
