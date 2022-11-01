using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CDLevel", menuName = "Picker3D/CDLevel")]
public class CDLevel : ScriptableObject
{
    public List<LevelData> Levels = new List<LevelData>();
}
