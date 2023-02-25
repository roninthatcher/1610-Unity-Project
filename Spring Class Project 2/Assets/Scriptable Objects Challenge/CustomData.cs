using UnityEngine;

[CreateAssetMenu(fileName = "Meele Unit")]
public class CustomData : ScriptableObject
{
    public string UnitName;
    public string NickName;
    public string Gender;
    public string FavoriteThing;
    public string DislikedThing;
    public int health;
    public int attack;
    public int defense;
    public int magic;

    public Sprite artwork;

    public AudioClip attackSound;
    public AudioClip victorySound;

    public void Print ()
    {
        Debug.Log(UnitName + ": Huh?! You want to call me" + NickName + ". Hm....... ya know what? I LOVE TI!");
    }
}
