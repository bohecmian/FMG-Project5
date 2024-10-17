using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public GameObject chest;
    public GameObject UI;

    public TextMeshProUGUI TreasureText;
    float T = 8;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(true);
            if (Input.GetKey(KeyCode.E)){
                T--;
                Destroy(chest);
                UI.SetActive(false);
            }
        }
    }
}
