﻿namespace MauiBlazorDotnet9;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "MauiBlazorDotnet9" };
    }
}
