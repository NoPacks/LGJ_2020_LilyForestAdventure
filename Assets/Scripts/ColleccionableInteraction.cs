﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ColleccionableInteraction : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            GetComponent<Collider2D>().enabled = false;
            Debug.Log("collect");
            audioSource.Play();
            Destroy(transform.GetChild(0));
        }
    }
}
