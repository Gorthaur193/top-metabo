﻿namespace top_metabo;

/// <summary>
/// red button by default
/// </summary>
public record ButtonAttributes(
    string Background = "#E4022F", 
    string BackgroundHover = "#B90011", 
    string TextColor = "white", 
    string TextColorHover = "white",
    string BorderColor = "#E4022F",
    string BorderColorHover = "#B90011");

public record TextboxAttributes(
    string Height = "",
    string Width = "28.75rem",
    string BorderColor = "#97B9B1",
    TextboxType Type = TextboxType.Text,
    string TextColor = "#25473F",
    string PlaceholderColor = "#7B8A9C",
    string PlaceholderText = "");