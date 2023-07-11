using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class HandleTracking : MonoBehaviour
{
    
    private ARTrackedImageManager m_TrackedImageManager;

    void OnEnable()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        m_TrackedImageManager.trackedImagesChanged += OnChanged;
    }

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            SetInformation _setInformation = newImage.gameObject.GetComponent<SetInformation>();
            _setInformation.SetName(newImage.referenceImage.name);
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            // Handle updated event
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }
}
