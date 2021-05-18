using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class Host : MonoBehaviour
{
    #region Variables
    public GameObject emote;

    public GameObject happy;
    public GameObject sad;
    public GameObject angry;
    public GameObject thirsty;
    public GameObject hungry;
    public GameObject love;
    #endregion

    /// <summary>
    /// Allows an actor to emote
    /// </summary>
    /// <param name="emote"></param>
    // public void Emote(GameObject emote)
    // {
    //     // Disable Old Emote
    //     this.emote.SetActive(false);
    //     // Replace with new Emote
    //     this.emote = emote;
    //     emote.SetActive(true);
    // }

    IEnumerator emoteAnimation() {
        emote.SetActive(true);
        yield return new WaitForSeconds(1f);
        emote.SetActive(false);
        yield break;
    }
    public void Emote(GameObject emote) {
        // Disable Old Emote
        this.emote.SetActive(false);
        // Replace with new Emote
        this.emote = emote;
        StartCoroutine("emoteAnimation");
    }
}
