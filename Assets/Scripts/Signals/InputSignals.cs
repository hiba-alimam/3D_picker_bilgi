using Keys;
using UnityEngine;
using UnityEngine.Events;
using Extensions;

namespace Signals
{
    public class InputSignals : MonoSingleton<InputSignals>
    {
        public UnityAction onFirstTimeTouchTaken = delegate { };
        public UnityAction onInputTaken = delegate { };
        public UnityAction onInputRelease = delegate { };
        public UnityAction<HorizontalInputParams> onInputDragged = delegate { };
    }
}