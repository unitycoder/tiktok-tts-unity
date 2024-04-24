// unity version https://github.com/unitycoder/tiktok-tts-unity
// based on https://github.com/Steve0929/tiktok-tts

using Newtonsoft.Json;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

namespace UnityLibrary.TTS
{
    public class TikTokTTS : MonoBehaviour
    {
        public UnityEvent<string> OnFileDownloaded;

        readonly string BASE_URL = "api22-normal-c-useast2a.tiktokv.com";
        readonly string API_PATH = "/media/api/text/speech/invoke/";

        public TMP_InputField inputField;
        public TMP_Dropdown dropdown;

        private void Awake()
        {
            ValidateSecret();
        }

        private void ValidateSecret()
        {
            if (string.IsNullOrEmpty(SECRETS.sessionID))
            {
                Debug.LogError("Please set the sessionID in the SECRETS.cs file.");
            }
        }

        public void CreateAudioFromText()
        {
            var msg = inputField.text;

            Debug.Log("get text: " + msg);

            // prepare text
            msg = msg.Replace("+", "plus");
            msg = msg.Replace("&", "and");
            msg = Regex.Replace(msg, @"\s+", "+"); // whitespace to +

            string speaker = dropdown.options[dropdown.value].text;
            Debug.Log("speaker: " + speaker);

            string url = $"https://{BASE_URL}{API_PATH}?text_speaker={speaker}&req_text={msg}&speaker_map_type=0&aid=1233";
            Debug.Log("url: " + url);

            StartCoroutine(GetAudio(url));
        }

        IEnumerator GetAudio(string url)
        {
            using (UnityWebRequest www = UnityWebRequest.Post(url, ""))
            {
                www.SetRequestHeader("User-Agent", "com.zhiliaoapp.musically/2022600030 (Linux; U; Android 7.1.2; es_ES; SM-G988N; Build/NRD90M;tt-ok/3.12.13.1)");
                www.SetRequestHeader("Cookie", string.Format("sessionid={0}", SECRETS.sessionID));
                www.SetRequestHeader("Accept-Encoding", "gzip,deflate,compress");

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
                        Debug.Log("\nReceived: " + www.downloadHandler.text);

                        Root root = JsonConvert.DeserializeObject<Root>(www.downloadHandler.text);

                        if (root.message != "success")
                        {
                            Debug.LogError("Error: " + root.message);
                            break;
                        }

                        string base64 = root.data.v_str;
                        byte[] bytes = System.Convert.FromBase64String(base64);

                        // save audio file
                        //string path = "Assets/Audio/TTS.mp3";
                        string path = Path.Combine(Application.streamingAssetsPath, "TTS.mp3");
                        File.WriteAllBytes(path, bytes);

                        OnFileDownloaded?.Invoke(path);

                        break;
                }
            }

        } // GetAudio()
    } // class TTS
}
