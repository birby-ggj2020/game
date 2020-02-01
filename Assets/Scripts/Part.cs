using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Parts/CreatePart", order = 1)]
public class Part : ScriptableObject  {
    public string Name;

    //public string IconImagePath {get;set;}
    public string Image;

    public PartType Type;
}
public enum PartType {
    Head,
    Body
}

//public 
