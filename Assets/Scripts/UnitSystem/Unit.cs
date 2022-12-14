using UnityEngine;

namespace UnitSystem
{
    public class Unit : MonoBehaviour
    {
        private void Start()
        {
            UnitSelections.Instance.unitList.Add(this.gameObject);
        }

        private void OnDestroy()
        {
            UnitSelections.Instance.unitList.Remove(this.gameObject);
        }
    }
}
