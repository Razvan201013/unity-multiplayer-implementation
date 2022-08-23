using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class cameraincorrectfix : MonoBehaviour
{
    public GameObject cam;

    private void Awake()
    {
        if (GetComponent<PhotonView>().IsMine)
        {
            cam.SetActive(true);
        }
        else
        {
            print("Incorrect PhotonView");
        }
    }

}
