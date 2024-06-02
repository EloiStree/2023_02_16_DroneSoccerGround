using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GSoccerMono_StartPointMagnet : MonoBehaviour
{

    public Transform m_whereToPull;
    public List<GameObject> m_objectToPullOnRequest;
    public UnityEvent<bool> m_onRequestShowingStartZone;

    public void SetStartZoneAsDisplay(bool isDisplay) {
        m_onRequestShowingStartZone.Invoke(isDisplay);
    }
    [ContextMenu("Display")]
    public void DisplayStartZone()
    {
        m_onRequestShowingStartZone.Invoke(true);
    }
    [ContextMenu("Hide")]
    public void HideStartZone()
    {
        m_onRequestShowingStartZone.Invoke(false);
    }

    [ContextMenu("Pull")]
    public void PullObjectToStartPoint()
    {
        foreach (var item in m_objectToPullOnRequest)
        {
            if (item != null) { 
                item.transform.position = m_whereToPull.position;
                item.transform.rotation = m_whereToPull.rotation;
            }
        }
    }

    public void Reset() {

        m_whereToPull = this.transform;
    }
}
