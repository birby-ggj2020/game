using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ExpandableButton : MonoBehaviour
{
    public int NumParts = 5;
    public GameObject ButtonPrefab;
    public Transform MenuPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddParts(IEnumerable<CreaturePart> parts){
        foreach(var part in parts){
            var button = GameObject.Instantiate(ButtonPrefab);
            button.transform.parent = MenuPanel;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
