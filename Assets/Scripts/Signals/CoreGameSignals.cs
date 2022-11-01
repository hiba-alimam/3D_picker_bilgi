using UnityEngine;
using UnityEngine.Events;

public class CoreGameSignals : MonoBehaviour
{
    //this is a messenger class
    #region Singleton
    
    public static CoreGameSignals Instance;

    public UnityAction<GameStates> onChangeGameState = delegate { }; // look up delegate function
    public UnityAction<int> onLevelInitialize = delegate { };
    public UnityAction onClearActiveLevel = delegate { };
    public UnityAction onLevelSuccessful = delegate { };
    public UnityAction onLevelFailed = delegate { };
    public UnityAction onNextLevel = delegate { };
    public UnityAction onRestartLevel = delegate { };
    public UnityAction onReset = delegate { };


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        Debug.LogWarning(Instance.GetInstanceID().ToString());

    }

    #endregion
}
