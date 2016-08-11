﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CustomizerPartsButton : MonoBehaviour
{
    private string partName;
    public Image thumb; 

    public void Init(string partName)
    {
        this.partName = partName;
        string thumbName = "";

        switch (partName)
        {
            case "cejas": thumbName = "icons_menu_eyebrows"; break;
            case "guantes": thumbName = "icons_menu_glove1"; break;
            case "peinados": thumbName = "icons_menu_hair"; break;
            case "pelos": thumbName = "icons_menu_hairColor"; break;
            case "cabezas": thumbName = "icons_menu_head"; break;
            case "narices": thumbName = "icons_menu_nose"; break;
            case "botas": thumbName = "icons_menu_shoes"; break;
            case "pantalon": thumbName = "icons_menu_shorts"; break;
            case "piel": thumbName = "icons_menu_skin"; break;
            case "": thumbName = "icons_menu_eyebrows"; break;
        }
        Texture2D texture = Resources.Load("Customizer/icons/" + thumbName) as Texture2D;
        thumb.sprite = Sprite.Create(texture, new Rect(0, 0, 512, 512), Vector2.zero);
    }
    public void OnClicked()
    {
        Events.OnCustomizerRefresh(partName);
    }
}
