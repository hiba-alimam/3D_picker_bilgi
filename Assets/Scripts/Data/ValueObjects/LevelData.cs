using System.Collections.Generic;
using System;

[Serializable]
   public class LevelData
    {
        public List<PoolData> PoolList = new List<PoolData>();
    }

    public struct PoolData
    {
        public sbyte RequiredObjectCount;
    }
