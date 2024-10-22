using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoClipPlayerController : MonoBehaviour
{
    public VideoClip videoClip; // Drag your VideoClip here in the Inspector
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.clip = videoClip;
        videoPlayer.playOnAwake = false;
        videoPlayer.isLooping = true; // Optional: Set to true if you want to loop the video

        // Set video player to start playing the video
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += PlayVideo;
    }

    public void PlayVideo(VideoPlayer vp)
    {
        videoPlayer.Play();
    }
}
