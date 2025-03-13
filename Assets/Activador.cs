using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activador : MonoBehaviour
{
    [SerializeField] UnityEvent activador;
    [SerializeField] UnityEvent desactivador;
    [SerializeField] List<string> tags;

    private void OnTriggerEnter(Collider other)
    {
        if (tags.Contains(other.tag))
        {
            activador?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (tags.Contains(other.tag))
        {
            desactivador?.Invoke();
        }
    }
}
