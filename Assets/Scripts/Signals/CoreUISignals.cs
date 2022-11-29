using UnityEngine;
using UnityEngine.Events;
using Enums;
using Extensions;

public class CoreUISignals : MonoSingleton<CoreUISignals>
{
    public UnityAction<UIPanelTypes, int> onOpenPanel = delegate{};
    public UnityAction<int> onClosePanel = delegate{};
    public UnityAction onCloseAllPanels = delegate{};
}
