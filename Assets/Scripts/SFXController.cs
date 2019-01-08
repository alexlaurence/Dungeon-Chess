using System.Collections;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    public AudioSource _as;
    public AudioClip[] audioClipArray;

    bool keepPlaying = true;

    void Start()
    {
        _as = GetComponent<AudioSource>();

        //Set default PlayerPrefs Value
        PlayerPrefs.SetInt("Drag", 0);
        PlayerPrefs.SetInt("Release", 0);
        PlayerPrefs.SetInt("Kill", 0);
        PlayerPrefs.SetInt("Promote", 0);
        PlayerPrefs.SetInt("Win", 0);
        PlayerPrefs.SetInt("Lose", 0);
    }

    //Play random clip
    public void PlayRandomAudioclip()
    {
        _as.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        _as.PlayOneShot(_as.clip);
    }

    //Play specific clip
    public void PlayAudioclip(int clipNumber)
    {
        _as.clip = audioClipArray[clipNumber];
        _as.PlayOneShot(_as.clip);
    }

    private void Update()
    {
        #region Pieces SFX
        if (PlayerPrefs.GetInt("Kill") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Kill", 0);

            StartCoroutine(playAudio(0, 8));
        }
        else if (PlayerPrefs.GetInt("Drag") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Drag", 0);

            StartCoroutine(playAudio(0, 22));
        }
        else if (PlayerPrefs.GetInt("Release") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Release", 0);

            StartCoroutine(playAudio(0, 19));
        }
        else if (PlayerPrefs.GetInt("Promote") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Promote", 0);

            StartCoroutine(playAudio(0, 5));
        }
        else if (PlayerPrefs.GetInt("Win") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Win", 0);

            StartCoroutine(playAudio(0, 10));
        }
        else if (PlayerPrefs.GetInt("Lose") == 1)
        {
            keepPlaying = true;

            //reset value
            PlayerPrefs.SetInt("Lose", 0);

            StartCoroutine(playAudio(0, 4));
        }
        #endregion
    }

    IEnumerator playAudio(float secs, int clipNumber)
    {
        while (keepPlaying == true)
        {
            // Put this coroutine to sleep until the next time the audio plays
            yield return new WaitForSeconds(secs);
            if (!_as.isPlaying)
            {
                //play specific audioclip element
                _as.clip = audioClipArray[clipNumber];
                _as.PlayOneShot(_as.clip);
            }
            keepPlaying = false;
        }
    }

}