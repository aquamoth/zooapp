using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageAwakeState : MonoBehaviour
{
    [SerializeField] private bool startActive;

    private void Start()
    {
        this.gameObject.SetActive(startActive);
    }
}
