using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnScr : MonoBehaviour
{
  public AudioSource myFx;
  public AudioClip clickFx;

  public void HoverSound()
  {
      myFx.PlayOneShot(clickFx);
  }
}
