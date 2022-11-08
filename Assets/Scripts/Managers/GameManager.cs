using UnityEngine;
//using Sirenix.OdinInspector;
using Enums;

public class GameManager : MonoBehaviour
{
    #region self variables

    #region serialized variable

    [SerializeField] private GameStates states; 

    #endregion
    #endregion


    private void Awake()
    {
        Application.targetFrameRate = 60;

    }

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
    }

    private void UnsubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState -= OnChangeGameState;
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }
     
    private void OnChangeGameState(GameStates state)
    {
        states = state;
    }
}

