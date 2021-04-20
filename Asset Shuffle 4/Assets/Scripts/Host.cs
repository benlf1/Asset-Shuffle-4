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
    #endregion

    /// <summary>
    /// Allows an actor to emote
    /// </summary>
    /// <param name="emote"></param>
    public void Emote(GameObject emote)
    {
        // Disable Old Emote
        this.emote.SetActive(false);
        // Replace with new Emote
        this.emote = emote;
        emote.SetActive(true);
    }
}
