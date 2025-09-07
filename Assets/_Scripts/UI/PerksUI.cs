using System.Collections.Generic;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine;

public class PerksUI : MonoBehaviour
{
    [SerializeField] private PerkUI perkUIPrefarb;
    private readonly List<PerkUI> perkUIs = new();
    public void AddPerkUI(Perk perk)
    {
        PerkUI perkUI = Instantiate(perkUIPrefarb, transform);
        perkUI.Setup(perk);
        perkUIs.Add(perkUI);
    }
    public void RemovePerkUI(Perk perk)
    {
        PerkUI perkUI = perkUIs.Where(pui => pui.Perk == perk).FirstOrDefault();
        if (perkUI != null)
        {
            perkUIs.Remove(perkUI);
            Destroy(perkUI.gameObject);
        }
    }
}
