using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public GameObject chest;
    public GameObject UI;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(true);
            if (Input.GetKey(KeyCode.E)){
                Destroy(chest);
                UI.SetActive(false);
            }
        }
    }
}
