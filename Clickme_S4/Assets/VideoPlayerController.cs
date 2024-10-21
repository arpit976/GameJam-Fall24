using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Call this function to play the video
    public void PlayVideo(string videoFilePath)
    {
        // Ensure the VideoPlayer component is set
        if (videoPlayer == null)
        {
            videoPlayer = gameObject.AddComponent<VideoPlayer>();
        }

        // Set the source to the file and play the video
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = videoFilePath;
        videoPlayer.playOnAwake = false;
        videoPlayer.isLooping = false;

        // Optional: Add an event to know when the video is finished
        videoPlayer.loopPointReached += OnVideoFinished;

        // Prepare and play the video
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += (VideoPlayer vp) => { vp.Play(); };
    }

    // Event triggered when the video finishes
    private void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video has finished playing.");
    }
}
