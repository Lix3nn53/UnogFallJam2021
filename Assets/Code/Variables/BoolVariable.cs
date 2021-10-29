using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Boolean")]
public class BoolVariable : ScriptableObject
{

#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public bool value;

    public void SetValue(bool v)
    {
        this.value = v;
    }

    public void SetValue(BoolVariable BoolVariable)
    {
        this.value = BoolVariable.value;
    }
}
