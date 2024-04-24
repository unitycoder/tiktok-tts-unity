using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace UnityLibrary.Examples
{
    public class PlayAudio : MonoBehaviour
    {
        public void Play(string path)
        {
            Debug.Log("PlayAudio.Play: " + path);
            StartCoroutine(GetAudio(path));
        }

        IEnumerator GetAudio(string path)
        {
            path = "file://" + path;
            Debug.Log("path: " + path);
            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(path, AudioType.MPEG))
            {
                yield return www.SendWebRequest();

                switch (www.result)
                {
                    case UnityWebRequest.Result.ConnectionError:
                    case UnityWebRequest.Result.DataProcessingError:
                        Debug.LogError("Error: " + www.error);
                        break;
                    case UnityWebRequest.Result.ProtocolError:
                        Debug.LogError(": HTTP Error: " + www.error);
                        break;
                    case UnityWebRequest.Result.Success:
                        Debug.Log(":\nReceived, size: " + www.downloadedBytes);

                        AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
                        audioSource.clip = clip;
                        audioSource.Play();
                        break;
                }
            }
        }
    }
}
