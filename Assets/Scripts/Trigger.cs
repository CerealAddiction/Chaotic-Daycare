using System;
using UnityEngine.Events;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField] bool destroyOnTriggerEnter;

    [SerializeField] string tagFilter;

    [SerializeField] UnityEvent onTriggerEnter;

    [SerializeField] UnityEvent onTriggerExit;


    void OnTriggerEnter(Collider other)
    {
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();

        if (destroyOnTriggerEnter)
        {
            Destroy(gameObject);
        }
    }
        void OnTriggerExit(Collider other)
        {
            if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
            onTriggerExit.Invoke();

        }

    

}