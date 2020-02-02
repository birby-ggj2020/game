using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEditor;

public static class GameUtils
{
    public static Sprite load_sprite(string sprite_path)
    {
        string filepath = Application.dataPath + "/" + sprite_path;
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(File.ReadAllBytes(filepath));
        var sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0f, 0f), 1.0f
        );
        return sprite;       
    }
}