using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    float nextTime = 0;
    private static int MAX_HUNGER = 100;
    private static int MAX_THIRST = 100;
    private int hunger = MAX_HUNGER;
    public ValueBarScript hungerBar;

    private int thirst = MAX_THIRST;
    public ValueBarScript thirstBar;

    private static int MIN_HAPPY = 70;
    private static int MIN_SAD = 30;

    private int emoteInterval = 5;
    private int count = 0; 
    public Host emotes;

    private int reduction = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime) {
            setHunger(hunger-reduction);
            setThirst(thirst-reduction);
            nextTime += 1f;

            count += 1;
            if (count == emoteInterval) {
                count = 0;
                if (hunger > MIN_HAPPY && thirst > MIN_HAPPY) {
                    emotes.Emote(emotes.happy);
                } else if (hunger > MIN_SAD && thirst > MIN_SAD) {
                    emotes.Emote(emotes.sad);
                } else {
                    emotes.Emote(emotes.angry);
                }
            }

            if (count == emoteInterval/2) {
                if (hunger <= MIN_HAPPY) {
                    emotes.Emote(emotes.hungry);
                } else if (thirst <= MIN_HAPPY) {
                    emotes.Emote(emotes.thirsty);
                }
            }

            if (hunger < 0 || thirst < 0) {
                gameObject.SetActive(false);
            }
        }
    }

    public void setHunger(int val) {
        if (val > MAX_HUNGER) {
            val = MAX_HUNGER;
        }
        hunger = val;
        hungerBar.setValue(val);
    }

    public void setThirst(int val) {
        if (val > MAX_THIRST) {
            val = MAX_THIRST;
        }
        thirst = val;
        thirstBar.setValue(val);
    }

    public void feed() {
        setHunger(hunger+10);
        emotes.Emote(emotes.love);
    }

    public void drink() {
        setThirst(thirst+10);
        emotes.Emote(emotes.love);
    }
}
