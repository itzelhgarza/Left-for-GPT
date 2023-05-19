using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class StreamVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
    }
    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared){
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
    }
}
