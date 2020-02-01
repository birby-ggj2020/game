using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

public class PartsMenu : MonoBehaviour
{
    private List<CreaturePart> m_parts;

    public GameObject PartButtonPrefab;
    void Start()
    {
        this.m_parts = GameState.creature_parts;
        var groupedParts = this.m_parts.GroupBy(p => p.type);

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
}