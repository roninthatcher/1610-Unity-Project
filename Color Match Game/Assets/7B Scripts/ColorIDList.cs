using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    public int num;

    public void SetCurrentColorRandomly()
    {
        num = colorIDList.Count - 1;
        currentColor = colorIDList[num];
    }
}
