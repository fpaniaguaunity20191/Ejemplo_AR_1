using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AsteroidsTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    public GameObject spawnPoint;
    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.TRACKED)
        {
            spawnPoint.SetActive(true);
            spawnPoint.GetComponent<Spawner>().StartSpawn();
        }
        else
        {
            spawnPoint.SetActive(false);
            spawnPoint.GetComponent<Spawner>().StopSpawn();
        }
    }
}
