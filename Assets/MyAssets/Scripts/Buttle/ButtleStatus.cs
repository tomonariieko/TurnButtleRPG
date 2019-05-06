﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtleStatus : MonoBehaviour
{
    static ButtleStatus _i = new ButtleStatus();
    public static ButtleStatus i
    {
        get { return _i; }
    }
    public List<ButtleInfo> players = new List<ButtleInfo>();

}

public class ButtleInfo
{
    public CharactorStatus charactorStatus;
    public int skillID;

    public ButtleInfo(int skillID)
    {
        this.skillID = skillID;
    }
}


