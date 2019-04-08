using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkipBtn : MonoBehaviour
{
    public VideoPlayer player;
    public float readyTime = 32.5f;

    private VideoClip video;
    private double startFrame;

    private GameObject controllerRay;  //수정사항
    private GameObject controllerCollider;  //수정사항

    private void Start()
    {
        controllerRay = GameObject.Find("VivePointers");  //수정사항
        controllerCollider = GameObject.Find("VROrigin_Colliders");  //수정사항
        controllerCollider.SetActive(false);  //수정사항
    }

    public void OnClick()
    {
        startFrame = player.frameRate * readyTime;
        player.frame = (long)startFrame;
        controllerRay.SetActive(false);  //수정사항
        controllerCollider.SetActive(true);  //수정사항
        gameObject.SetActive(false);
    }

}
