﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.JoinQueue;

[GenerateTypedNameReferences]
public sealed partial class QueueGui : Control
{
    public event Action? QuitPressed;


    public QueueGui()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
        LayoutContainer.SetAnchorPreset(this, LayoutContainer.LayoutPreset.Wide);

        QuitButton.OnPressed += (_) => QuitPressed?.Invoke();
    }


    public void UpdateInfo(int total, int position)
    {
        QueueTotal.Text = total.ToString();
        QueuePosition.Text = position.ToString();
    }
}