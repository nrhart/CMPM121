using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Cameras : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam3;
    public GameObject camOrth;
    public GameObject camScpt;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam3.SetActive(false);
        camOrth.SetActive(false);
        camScpt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            CameraSwitch();
        }
    }

    public void CameraSwitch () {
        if (cam1.activeInHierarchy) {
            cam3.SetActive(true);
            cam1.SetActive(false);
            text.text = "Current Camera:\nThird person";
        }
        else if (cam3.activeInHierarchy) {
            camOrth.SetActive(true);
            cam3.SetActive(false);
            text.text = "Current Camera:\nOrthographic";
        }
        else if (camOrth.activeInHierarchy) {
            camScpt.SetActive(true);
            camOrth.SetActive(false);
            text.text = "Current Camera:\nScripted";
        }
        else if (camScpt.activeInHierarchy) {
            cam1.SetActive(true);
            camScpt.SetActive(false);
            text.text = "Current Camera:\nFirst person";
        }
    }
}