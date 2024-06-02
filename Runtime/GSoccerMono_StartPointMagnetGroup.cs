using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSoccerMono_StartPointMagnetGroup : MonoBehaviour
{
    public GSoccerMono_StartPointMagnetGroup[] m_startPointGroups;
    public GSoccerMono_StartPointMagnet [] m_startPointMagnets;



    public void SetStartZoneAsDisplay(bool isDisplay)
    {
        foreach (var item in m_startPointMagnets)
        {
            if (item != null)
                item.SetStartZoneAsDisplay(isDisplay);
        }
        foreach(var item in m_startPointGroups)
        {
            if(item!=null)
                item.SetStartZoneAsDisplay(isDisplay);
        }
    }
    [ContextMenu("Display")]
    public void DisplayStartZone()
    {
        SetStartZoneAsDisplay(true);
    }
    [ContextMenu("Hide")]
    public void HideStartZone()
    {
        SetStartZoneAsDisplay(false);
    }

    [ContextMenu("Pull")]
    public void PullLinkedObjectToStartPoint()
    {
        foreach (var startPointMagnet in m_startPointMagnets)
        {
            if(startPointMagnet != null)
                startPointMagnet.PullObjectToStartPoint();
        }
        foreach (var startPointGroup in m_startPointGroups)
        {
            if(startPointGroup != null)
                startPointGroup.PullLinkedObjectToStartPoint();
        }
    }
}
