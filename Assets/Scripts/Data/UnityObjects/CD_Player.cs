using Data.ValueObjects;
using UnityEngine;

namespace Data.ValueObjects
{
    [CreateAssetMenu(fileName = "CD_Player", menuName = "Picker3D/CD_Player", order = 0)]

    public class CD_Player : ScriptableObject
    {
        public PlayerData Data;
    }
}
